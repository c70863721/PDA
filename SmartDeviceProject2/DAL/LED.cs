using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
namespace Tsmt.DAL
{
    class LED
    {
        class NLED_SETTINGS_INFO
        {
            public uint LedNum;
            public uint OffOnBlink;
            public int TotalCycleTime=0;
            public int OnTime=0;
            public int OffTime=0;
            public int MetaCycleOn=0;
            public int MetaCycleOff=0;
        }

        class NLED_COUNT_INFO
        {
            public int cLeds=0;
        }

        const int NLED_COUNT_INFO_ID = 0;
        const int NLED_SETTINGS_INFO_ID = 2;

        //振动器状态
        public enum Status
        {
            OFF = 0,
            ON,
            BLINK
        }

        /// <summary>
        /// 获得LED个数
        /// </summary>
        [DllImport("coredll.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode,
                        EntryPoint = "NLedGetDeviceInfo", PreserveSig = true, SetLastError = true)]
        extern static bool NLedGetDeviceInfo(uint nID, NLED_COUNT_INFO pOutput);


        /// <summary>
        /// 设置LED状态
        /// </summary>
        [DllImport("coredll.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode,
               EntryPoint = "NLedSetDevice", PreserveSig = true, SetLastError = false)]
        extern static bool NLedSetDevice(uint nID, NLED_SETTINGS_INFO pOutput);

        /// <summary>
        /// 获得LED个数
        /// </summary>
        public int GetLedCount()
        {
            int wCount = 0;
            NLED_COUNT_INFO nci = new NLED_COUNT_INFO();
            if (NLedGetDeviceInfo(NLED_COUNT_INFO_ID, nci))
            {
                wCount = nci.cLeds;
            }
            return wCount;
        }

        /// <summary>
        /// 设置LED状态
        /// </summary>
        /// <param name="wLed">Led（1/0），一般是1，即第二个LED</param>
        /// <param name="wStatus">状态</param>
        public void SetLedStatus(int wLed, Status wStatus)
        {
            NLED_SETTINGS_INFO nsi = new NLED_SETTINGS_INFO();
            nsi.LedNum = (uint)wLed;
            nsi.OffOnBlink = (uint)wStatus;
            NLedSetDevice(NLED_SETTINGS_INFO_ID, nsi);
        }

        /// <summary>
        /// 设置LED状态
        /// </summary>
        /// <param name="wLed">Led（1/0）</param>
        /// <param name="wStatus">状态</param>
        /// <param name="millisecondsTimeout">持续时间</param>
        public void SetLedStatus(int wLed, Status wStatus, int millisecondsTimeout)
        {
            this.SetLedStatus(wLed, wStatus);
            System.Threading.Thread.Sleep(millisecondsTimeout);
            //关闭震动
            NLED_SETTINGS_INFO nsi = new NLED_SETTINGS_INFO();
            nsi.LedNum = (uint)wLed;
            nsi.OffOnBlink = (uint)Status.OFF;
            NLedSetDevice(NLED_SETTINGS_INFO_ID, nsi);
        }

        /// <summary>
        /// 设置LED状态
        /// </summary>
        /// <param name="wStatus">状态</param>
        public void SetLedStatus(Status wStatus)
        {
            NLED_SETTINGS_INFO nsi = new NLED_SETTINGS_INFO();
            nsi.OffOnBlink = (uint)wStatus;
            //自动查找震动LED
            for (int i = 0; i < this.GetLedCount(); i++)
            {
                nsi.LedNum = (uint)i;
                NLedSetDevice(NLED_SETTINGS_INFO_ID, nsi);
            }
        }

        /// <summary>
        /// 设置LED状态
        /// </summary>
        /// <param name="wStatus">状态</param>
        /// <param name="millisecondsTimeout">持续时间</param>
        public void SetLedStatus(Status wStatus, int millisecondsTimeout)
        {
            this.SetLedStatus(wStatus);
            System.Threading.Thread.Sleep(millisecondsTimeout);
            //关闭震动
            NLED_SETTINGS_INFO nsi = new NLED_SETTINGS_INFO();
            nsi.OffOnBlink = (uint)Status.OFF;
            for (int i = 0; i < this.GetLedCount(); i++)
            {
                nsi.LedNum = (uint)i;
                NLedSetDevice(NLED_SETTINGS_INFO_ID, nsi);
            }
        }

        /// <summary>
        /// 循环震动
        /// </summary>
        /// <param name="times">次数</param>
        public void CycleVibrate(int times)
        {
            for (int i = 0; i < times; i++)
            {
                this.SetLedStatus(Status.ON);
                Thread.Sleep(400);
                this.SetLedStatus(Status.OFF);
                Thread.Sleep(200);
            }
        }
    }
}
