using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
/*
 * Written by David Higgins - X00003549
 * Program is provided as-is
 * All rights reserved
 */
namespace CiscoConfigMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            FileInfo t = new FileInfo(saveFileDialog1.FileName);
            StreamWriter Tex = t.CreateText();
          

            Tex.Write("!Cisco Config Maker - By Hig\r\n");
            #region Startup
            if (cbWriteStartup.Checked)
            {
                Tex.Write("\r\n\n!Writing Automated Startup\r\n\n");
                
                Tex.Write("enable\r\nconfigure terminal\r\nno ip domain-lookup\r\n"); //Default first line
                #region Hostname
                if (cbHostname.Checked)
                {
                    Tex.Write("hostname " + tbHostname.Text + "\r\n");
                }
                #endregion
                #region Secret
                if (cbSecret.Checked)
                {
                    Tex.Write("enable secret " + tbSecret.Text + "\r\n");
                }
                #endregion
                #region Password
                if (cbPassword.Checked)
                {
                    Tex.Write("line console 0\r\nlogging synchronous\r\npassword " + tbPassword.Text + "\r\nlogin\r\n"); //Enable Password
                    Tex.Write("line vty 5 15\r\npassword " + tbPassword.Text + "\r\nlogin\r\n"); //Enable Password
                }
                #endregion
                Tex.Write("end\r\n");
            }
            #endregion            
            #region Vlans
            //I'm ashamed of all the repeated code
            if (cbWriteVlan.Checked)
            {
                Tex.Write("\r\n\n!Writing VLANs\r\n\n");
                Tex.Write("enable\r\nconfigure terminal\r\n");
                
                if (cbVlan1.Checked)
                {
                    Tex.Write("vlan " + tbVlanID1.Text + "\r\nname " + tbVlanName1.Text + "\r\n");
                    if (cbAssignToInterface1.Checked)
                    {
                        Tex.Write("int " + tbInterfaceName1.Text + "\r\nswitchport mode access\r\nswitchport access vlan " + tbVlanID1.Text + "\r\nno shut\r\n");
                    }
                }
                if (cbVlan2.Checked)
                {
                    Tex.Write("vlan " + tbVlanID2.Text + "\r\nname " + tbVlanName2.Text + "\r\n");
                    if (cbAssignToInterface2.Checked)
                    {
                        Tex.Write("int " + tbInterfaceName2.Text + "\r\nswitchport mode access\r\nswitchport access vlan " + tbVlanID2.Text + "\r\nno shut\r\n");
                    }
                }
                if (cbVlan3.Checked)
                {
                    Tex.Write("vlan " + tbVlanID3.Text + "\r\nname " + tbVlanName3.Text + "\r\n");
                    if (cbAssignToInterface3.Checked)
                    {
                        Tex.Write("int " + tbInterfaceName3.Text + "\r\nswitchport mode access\r\nswitchport access vlan " + tbVlanID3.Text + "\r\nno shut\r\n");
                    }
                }
                if (cbVlan4.Checked)
                {
                    Tex.Write("vlan " + tbVlanID4.Text + "\r\nname " + tbVlanName4.Text + "\r\n");
                    if (cbAssignToInterface4.Checked)
                    {
                        Tex.Write("int " + tbInterfaceName4.Text + "\r\nswitchport mode access\r\nswitchport access vlan " + tbVlanID4.Text + "\r\nno shut\r\n");
                    }
                }
                if (cbVlan5.Checked)
                {
                    Tex.Write("vlan " + tbVlanID5.Text + "\r\nname " + tbVlanName5.Text + "\r\n");
                    if (cbAssignToInterface5.Checked)
                    {
                        Tex.Write("int " + tbInterfaceName5.Text + "\r\nswitchport mode access\r\nswitchport access vlan " + tbVlanID5.Text + "\r\nno shut\r\n");
                    }
                }
                if (cbVlan6.Checked)
                {
                    Tex.Write("vlan " + tbVlanID6.Text + "\r\nname " + tbVlanName6.Text + "\r\n");
                    if (cbAssignToInterface6.Checked)
                    {
                        Tex.Write("int " + tbInterfaceName6.Text + "\r\nswitchport mode access\r\nswitchport access vlan " + tbVlanID6.Text + "\r\nno shut\r\n");
                    }
                }
                if (cbVlan7.Checked)
                {
                    Tex.Write("vlan " + tbVlanID7.Text + "\r\nname " + tbVlanName7.Text + "\r\n");
                    if (cbAssignToInterface7.Checked)
                    {
                        Tex.Write("int " + tbInterfaceName7.Text + "\r\nswitchport mode access\r\nswitchport access vlan " + tbVlanID7.Text + "\r\nno shut\r\n");
                    }
                }				
                Tex.Write("end\r\n");
            }
            #endregion
            #region Switching
            if (cbWriteSwitchCommands.Checked)
            {
                Tex.Write("\r\n\n!Writing Switching Commands\r\n\n");
                Tex.Write("enable\r\nconfigure terminal\r\n");
                if (cbManagementVlan.Checked)
                {
                    Tex.Write("vlan " + tbManagementVlanID.Text + "\r\nname " + tbManagementVlanName.Text + "\r\n");
                    Tex.Write("int vlan " + tbManagementVlanID.Text + "\r\nip address " + tbManagementIP.Text + " " + tbManagementNetmask.Text + "\r\n");
                }

                if (cbTrunking.Checked)
                {
                    Tex.Write("int " + tbTrunkInterface.Text + "\r\nswitchport mode trunk\r\nswitchport trunk native vlan " + tbTrunkingNativeVlan.Text + "\r\nno shut\r\n");
                }
                Tex.Write("end\r\n");
            }
            #endregion
            #region Interfaces
            if (cbWriteIface1.Checked)
            {
                Tex.Write("\r\n\n!Writing Interface1\r\n\n");

                if (cbIface1Name.Checked)
                {
                    Tex.Write("enable\r\nconfigure terminal\r\ninterface " + tbIface1Name.Text + "\r\n");

                    if (cbIface1IP.Checked) //IP
                    {
                        Tex.Write("ip address " + tbIface1IP.Text + " " + tbIface1Netmask.Text + "\r\n");
                    }

                    if (cbIface1Shut.Checked)
                    {
                        Tex.Write("shutdown\r\n");
                    }
                    else
                    {
                        Tex.Write("no shutdown\r\n");
                    }

                    if (cbIFace1ClockRate.Checked)
                    {
                        Tex.Write("clock rate " + tbIFace1ClockRate.Text + "\r\n");
                    }

                    if (cbDHCPHelperAddress1.Checked)
                    {
                        Tex.Write("ip helper-address " + tbDHCPHelperAddress1.Text + "\r\n");
                    }

                    Tex.Write("end\r\n");
                }
            }

            if (cbWriteIface2.Checked)
            {
                Tex.Write("\r\n\n!Writing Interface2\r\n\n");

                if (cbIface2Name.Checked)
                {
                    Tex.Write("enable\r\nconfigure terminal\r\ninterface " + tbIface2Name.Text + "\r\n");

                    if (cbIface2IP.Checked) //IP
                    {
                        Tex.Write("ip address " + tbIface2IP.Text + " " + tbIface2Netmask.Text + "\r\n");
                    }

                    if (cbIface2Shut.Checked)
                    {
                        Tex.Write("shutdown\r\n");
                    }
                    else
                    {
                        Tex.Write("no shutdown\r\n");
                    }

                    if (cbIFace2ClockRate.Checked)
                    {
                        Tex.Write("clock rate " + tbIFace2ClockRate.Text + "\r\n");
                    }

                    if (cbDHCPHelperAddress2.Checked)
                    {
                        Tex.Write("ip helper-address " + tbDHCPHelperAddress2.Text + "\r\n");
                    }
                }

                Tex.Write("end\r\n");
            }
            #endregion
            #region OSPF
            if (cbWriteOSPF.Checked)
            {
                Tex.Write("\r\n\n!Writing OSPF\r\n\n");
                Tex.Write("enable\r\nconfigure terminal\r\n");

                if (cbOSPFID.Checked)
                {
                    Tex.Write("router ospf " + tbOSPFAreaID.Text + "\r\n");
                    if (cbOSPFNetworkID1.Checked)
                    {
                        Tex.Write("network " + tbOSPFNetworkID1.Text + " " + tbOSPFInvMask1.Text + "\r\n");
                    }
                    if (cbOSPFNetworkID2.Checked)
                    {
                        Tex.Write("network " + tbOSPFNetworkID2.Text + " " + tbOSPFInvMask2.Text + "\r\n");
                    }
                }

                Tex.Write("end\r\n");
            }
            #endregion
            #region EIGRP
            if (cbWriteEIGRP.Checked)
            {
                Tex.Write("\r\n\n!Writing EIGRP\r\n\n");
                Tex.Write("enable\r\nconfigure terminal\r\n");

                if (cbEIGRPID.Checked)
                {
                    Tex.Write("router eigrp " + tbEIGRPAreaID.Text + "\r\n");
                    if (cbEIGRPNetwork1.Checked)
                    {
                        Tex.Write("network " + tbEIGRPNetworkID1.Text + "\r\n");
                    }
                    if (cbEIGRPNetwork2.Checked)
                    {
                        Tex.Write("network " + tbEIGRPNetworkID2.Text + "\r\n");
                    }
                }

                Tex.Write("end\r\n");
            }
            #endregion
            #region DHCP
            if (cbWriteDHCP.Checked)
            {
                Tex.Write("\r\n\n!Writing DHCP\r\n\n");
                Tex.Write("enable\r\nconfigure terminal\r\n");

                if (cbExcludeRange1.Checked)
                {
                    Tex.Write("ip dhcp excluded-address " + tbExcludeRangeStart1.Text + " " + tbExcludeRangeStop1.Text + "\r\n");
                }

                if (cbExcludeRange2.Checked)
                {
                    Tex.Write("ip dhcp excluded-address " + tbExcludeRangeStart2.Text + " " + tbExcludeRangeStop2.Text + "\r\n");
                }

                if (cbDHCPPool.Checked)
                {
                    Tex.Write("ip dhcp pool " + tbDHCPPool.Text + "\r\n");
                    Tex.Write("network " + tbDHCPNetworkIP.Text + " " + tbDHCPNetworkNetmask.Text + "\r\n");
                }

                if (cbDHCPDnsServer.Checked)
                {
                    Tex.Write("dns-server " + tbDHCPDnsServer.Text + "\r\n");
                }

                if (cbDHCPDefaultRouter.Checked)
                {
                    Tex.Write("default-router " + tbDHCPDefaultRouter.Text + "\r\n");
                }

                Tex.Write("end\r\n");
            }
            #endregion
            #region NAT
            if (cbWriteNAT.Checked)
            {
                Tex.Write("\r\n\n!Writing NAT\r\n\n");
                Tex.Write("enable\r\nconfigure terminal\r\n");

                if (cbNATInsideInt.Checked)
                {
                    Tex.Write("interface " + tbNATInsideInt.Text + "\r\n");
                    Tex.Write("ip nat inside\r\n");
                    Tex.Write("exit\r\n");
                }

                if (cbNATOutsideInt.Checked)
                {
                    Tex.Write("interface " + tbNATOutsideInt.Text + "\r\n");
                    Tex.Write("ip nat outside\r\n");
                    Tex.Write("exit\r\n");
                }

                if (cbInsideNAT.Checked)
                {
                    Tex.Write("ip nat inside source static " + tbInsideNATPrivate.Text + " " + tbInsideNATPublic.Text + "\r\n");
                }

                if (cbOutsideNAT.Checked)
                {
                    Tex.Write("ip nat outside source static " + tbInsideNATPrivate.Text + " " + tbInsideNATPublic.Text + "\r\n");
                }

                Tex.Write("end\r\n");
            }
            #endregion
            #region ACL
            if (cbWriteStandardACL.Checked)
            {
                Tex.Write("\r\n\n!Writing Standard ACLs\r\n\n");
                Tex.Write("enable\r\nconfigure terminal\r\n");

                Tex.Write("ip access-list standard " + tbStandardACLName.Text + "\r\n");

                if (cbStandardACL1.Checked)
                    Tex.Write(tbStandardACL1.Text + "\r\n");
                if (cbStandardACL2.Checked)
                    Tex.Write(tbStandardACL2.Text + "\r\n");
                if (cbStandardACL3.Checked)
                    Tex.Write(tbStandardACL3.Text + "\r\n");
                if (cbStandardACL4.Checked)
                    Tex.Write(tbStandardACL4.Text + "\r\n");
                if (cbStandardACL5.Checked)
                    Tex.Write(tbStandardACL5.Text + "\r\n");
                if (cbStandardACL6.Checked)
                    Tex.Write(tbStandardACL6.Text + "\r\n");
                if (cbStandardACL7.Checked)
                    Tex.Write(tbStandardACL7.Text + "\r\n");
                if (cbStandardACL8.Checked)
                    Tex.Write(tbStandardACL8.Text + "\r\n");
                if (cbStandardACLApply.Checked)
                {
                    Tex.Write("interface " + tbStandardACLApply.Text + "\r\n");
                    Tex.Write("ip access-group " + tbStandardACLName.Text + " " + tbStandardACLApplyInOut + "\r\n");
                }
                Tex.Write("end\r\n");
            }

            if (cbWriteExtendedACL.Checked)
            {
                Tex.Write("\r\n\n!Writing Extended ACLs\r\n\n");
                Tex.Write("enable\r\nconfigure terminal\r\n");

                Tex.Write("ip access-list extended " + tbExtendedACLName.Text + "\r\n");

                if (cbExtendedACL1.Checked)
                    Tex.Write(tbExtendedACL1.Text + "\r\n");
                if (cbExtendedACL2.Checked)
                    Tex.Write(tbExtendedACL2.Text + "\r\n");
                if (cbExtendedACL3.Checked)
                    Tex.Write(tbExtendedACL3.Text + "\r\n");
                if (cbExtendedACL4.Checked)
                    Tex.Write(tbExtendedACL4.Text + "\r\n");

                if (cbExtendedACLApply.Checked)
                {
                    Tex.Write("interface " + tbExtendedACLApply.Text + "\r\n");
                    Tex.Write("ip access-group " + tbExtendedACLName.Text + " " + tbExtendedACLApplyInOut + "\r\n");
                }

                Tex.Write("end\r\n");
            }
            #endregion
            Tex.Write("exit\r\n");

            Tex.Close();
        }
    }
}
