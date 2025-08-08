using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Sineva.VHL.Data;
using Sineva.VHL.Device;
using Sineva.VHL.Library;
using Sineva.VHL.Library.Servo;

namespace Sineva.VHL.Device.Design
{
    public partial class ucServoErrorTest : UCon, IUpdateUCon
    {
        #region Fields
        private DevTransfer m_devTransfer = null;
        private DevFoupGripper m_devFoupGripper = null;
        private DevAntiDrop m_devFrontAntiDrop = null;
        private DevAntiDrop m_devRearAntiDrop = null;

        private List<CheckBox> m_cbAxisList = new List<CheckBox>();
        private List<CheckBox> m_cbErrorList = new List<CheckBox>();

        #endregion

        #region Fields

        #endregion

        public ucServoErrorTest()
        {
            InitializeComponent();
            Initialize();
        }

        public bool Initialize()
        {
            m_devTransfer = DevicesManager.Instance.DevTransfer;
            m_devFoupGripper = DevicesManager.Instance.DevFoupGripper;
            m_devFrontAntiDrop = DevicesManager.Instance.DevFrontAntiDrop;
            m_devRearAntiDrop = DevicesManager.Instance.DevRearAntiDrop;

            m_cbAxisList.Clear();
            m_cbAxisList.Add(cbMaster);
            m_cbAxisList.Add(cbSlave);
            m_cbAxisList.Add(cbSlide);
            m_cbAxisList.Add(cbHoist);
            m_cbAxisList.Add(cbRotate);
            m_cbAxisList.Add(cbAntiDropFront);
            m_cbAxisList.Add(cbAntiDropRear);

            m_cbErrorList.Clear();
            m_cbErrorList.Add(cbDrive10);
            m_cbErrorList.Add(cbDrive14);
            m_cbErrorList.Add(cbDrive16);
            m_cbErrorList.Add(cbDrive15);
            m_cbErrorList.Add(cbDrive21);
            m_cbErrorList.Add(cbDrive23);
            m_cbErrorList.Add(cbDrive22);
            m_cbErrorList.Add(cbDrive25);
            m_cbErrorList.Add(cbDrive26);
            m_cbErrorList.Add(cbDrive24);
            m_cbErrorList.Add(cbDrive30);
            m_cbErrorList.Add(cbDrive31);
            m_cbErrorList.Add(cbDrive40);
            m_cbErrorList.Add(cbDrive42);
            m_cbErrorList.Add(cbMXP555);
            m_cbErrorList.Add(cbMXP514);

            return true;
        }
        public void UpdateState()
        {
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (CheckBox cb in m_cbAxisList)
                {
                    if (cb.Tag.ToString() == m_devTransfer.AxisMaster.AxisName.ToString() && cb.Checked)
                    {
                        List<ushort> alarmlist = SetMXPTestAlarmFlag();
                        m_devTransfer.AxisMaster.GetDevAxis().GetAxis().MXPErrorTest = (alarmlist);

                        List<ushort> drivealarmlist = SetDriveTestAlarmFlag();
                        m_devTransfer.AxisMaster.GetDevAxis().GetAxis().DriveErrorTest = (drivealarmlist);
                    }
                    else if (cb.Tag.ToString() == m_devTransfer.AxisSlave.AxisName.ToString() && cb.Checked)
                    {
                        List<ushort> alarmlist = SetMXPTestAlarmFlag();
                        m_devTransfer.AxisSlave.GetDevAxis().GetAxis().MXPErrorTest = (alarmlist);

                        List<ushort> drivealarmlist = SetDriveTestAlarmFlag();
                        m_devTransfer.AxisSlave.GetDevAxis().GetAxis().DriveErrorTest = (drivealarmlist);
                    }
                    else if (cb.Tag.ToString() == m_devFoupGripper.AxisSlide.AxisName.ToString() && cb.Checked)
                    {
                        List<ushort> alarmlist = SetMXPTestAlarmFlag();
                        m_devFoupGripper.AxisSlide.GetDevAxis().GetAxis().MXPErrorTest = (alarmlist);

                        List<ushort> drivealarmlist = SetDriveTestAlarmFlag();
                        m_devFoupGripper.AxisSlide.GetDevAxis().GetAxis().DriveErrorTest = (drivealarmlist);
                    }
                    else if (cb.Tag.ToString() == m_devFoupGripper.AxisHoist.AxisName.ToString() && cb.Checked)
                    {
                        List<ushort> alarmlist = SetMXPTestAlarmFlag();
                        m_devFoupGripper.AxisHoist.GetDevAxis().GetAxis().MXPErrorTest = (alarmlist);

                        List<ushort> drivealarmlist = SetDriveTestAlarmFlag();
                        m_devFoupGripper.AxisHoist.GetDevAxis().GetAxis().DriveErrorTest = (drivealarmlist);
                    }
                    else if (cb.Tag.ToString() == m_devFoupGripper.AxisTurn.AxisName.ToString() && cb.Checked)
                    {
                        List<ushort> alarmlist = SetMXPTestAlarmFlag();
                        m_devFoupGripper.AxisTurn.GetDevAxis().GetAxis().MXPErrorTest = (alarmlist);

                        List<ushort> drivealarmlist = SetDriveTestAlarmFlag();
                        m_devFoupGripper.AxisTurn.GetDevAxis().GetAxis().DriveErrorTest = (drivealarmlist);
                    }
                    else if (cb.Tag.ToString() == m_devFrontAntiDrop.Axis.AxisName.ToString() && cb.Checked)
                    {
                        List<ushort> alarmlist = SetMXPTestAlarmFlag();
                        m_devFrontAntiDrop.Axis.GetDevAxis().GetAxis().MXPErrorTest = (alarmlist);

                        List<ushort> drivealarmlist = SetDriveTestAlarmFlag();
                        m_devFrontAntiDrop.Axis.GetDevAxis().GetAxis().DriveErrorTest = (drivealarmlist);
                    }
                    else if (cb.Tag.ToString() == m_devRearAntiDrop.Axis.AxisName.ToString() && cb.Checked)
                    {
                        List<ushort> alarmlist = SetMXPTestAlarmFlag();
                        m_devRearAntiDrop.Axis.GetDevAxis().GetAxis().MXPErrorTest = (alarmlist);

                        List<ushort> drivealarmlist = SetDriveTestAlarmFlag();
                        m_devRearAntiDrop.Axis.GetDevAxis().GetAxis().DriveErrorTest = (drivealarmlist);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.WriteLog(ex.ToString());
            }
        }
        public List<ushort> SetDriveTestAlarmFlag()
        {
            List<ushort> occurAlarm = new List<ushort>();
            
            if (cbDrive10.Checked)
                occurAlarm.Add(16); //10
            if (cbDrive14.Checked)
                occurAlarm.Add(20); //14
            if (cbDrive16.Checked)
                occurAlarm.Add(22); //16
            if (cbDrive15.Checked)
                occurAlarm.Add(21); //15
            if (cbDrive21.Checked)
                occurAlarm.Add(33); //21
            if (cbDrive23.Checked)
                occurAlarm.Add(35); //23
            if (cbDrive22.Checked)
                occurAlarm.Add(34); //22
            if (cbDrive25.Checked)
                occurAlarm.Add(37); //25
            if (cbDrive26.Checked)
                occurAlarm.Add(38); //26
            if (cbDrive24.Checked)
                occurAlarm.Add(36); //24
            if (cbDrive30.Checked)
                occurAlarm.Add(48); //30
            if (cbDrive31.Checked)
                occurAlarm.Add(49); //31
            if (cbDrive40.Checked)
                occurAlarm.Add(64); //40
            if (cbDrive42.Checked)
                occurAlarm.Add(66); //42

            return occurAlarm;
        }

        public List<ushort> SetMXPTestAlarmFlag()
        {
            List<ushort> occurAlarm = new List<ushort>();

            if (cbMXP555.Checked)
                occurAlarm.Add(555);
            if (cbMXP514.Checked)
                occurAlarm.Add(514);

            return occurAlarm;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (CheckBox axis in m_cbAxisList)
            {
                axis.Checked = false;
            }
            foreach (CheckBox err in m_cbErrorList)
            {
                err.Checked = false;
            }

            m_devTransfer.AxisMaster.GetDevAxis().GetAxis().MXPErrorTest.Clear();
            m_devTransfer.AxisSlave.GetDevAxis().GetAxis().MXPErrorTest.Clear();
            m_devFoupGripper.AxisSlide.GetDevAxis().GetAxis().MXPErrorTest.Clear();
            m_devFoupGripper.AxisHoist.GetDevAxis().GetAxis().MXPErrorTest.Clear();
            m_devFoupGripper.AxisTurn.GetDevAxis().GetAxis().MXPErrorTest.Clear();
            m_devFrontAntiDrop.Axis.GetDevAxis().GetAxis().MXPErrorTest.Clear();
            m_devRearAntiDrop.Axis.GetDevAxis().GetAxis().MXPErrorTest.Clear();

            m_devTransfer.AxisMaster.GetDevAxis().GetAxis().DriveErrorTest.Clear();
            m_devTransfer.AxisSlave.GetDevAxis().GetAxis().DriveErrorTest.Clear();
            m_devFoupGripper.AxisSlide.GetDevAxis().GetAxis().DriveErrorTest.Clear();
            m_devFoupGripper.AxisHoist.GetDevAxis().GetAxis().DriveErrorTest.Clear();
            m_devFoupGripper.AxisTurn.GetDevAxis().GetAxis().DriveErrorTest.Clear();
            m_devFrontAntiDrop.Axis.GetDevAxis().GetAxis().DriveErrorTest.Clear();
            m_devRearAntiDrop.Axis.GetDevAxis().GetAxis().DriveErrorTest.Clear();
        }
    }
}
