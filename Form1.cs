using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WLANDeleteProfile {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Upd();
        }

        private void Upd() {
            lvW.Enabled = false; Update();
            try {
                String dir = Path.Combine(Path.GetTempPath(), "WLANDeleteProfile_" + DateTime.Now.Ticks);
                Directory.CreateDirectory(dir);
                var psi = new ProcessStartInfo("netsh.exe", " wlan export profile ");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.WorkingDirectory = dir;
                var p = Process.Start(psi);
                p.WaitForExit();
                lvW.Items.Clear();
                foreach (String fp in Directory.GetFiles(dir, "*.xml")) {
                    XmlDocument xmlo = new XmlDocument();
                    xmlo.Load(fp);
                    var xnm = new XmlNamespaceManager(xmlo.NameTable);
                    xnm.AddNamespace("a", "http://www.microsoft.com/networking/WLAN/profile/v1");
                    var Name = (xmlo.SelectSingleNode("/a:WLANProfile/a:name/text()", xnm) ?? xmlo.CreateTextNode("")).Value;
                    var SSID = (xmlo.SelectSingleNode("/a:WLANProfile/a:SSIDConfig/a:SSID/a:name/text()", xnm) ?? xmlo.CreateTextNode("")).Value;
                    var Auth = (xmlo.SelectSingleNode("/a:WLANProfile/a:MSM/a:security/a:authEncryption/a:authentication/text()", xnm) ?? xmlo.CreateTextNode("")).Value;

                    var lvi = new ListViewItem(Name);
                    lvi.SubItems.Add(SSID);
                    lvi.SubItems.Add(Auth);
                    lvW.Items.Add(lvi);
                }
                Directory.Delete(dir, true);
            }
            finally {
                lvW.Enabled = true;
            }
        }

        private void mRemove_Click(object sender, EventArgs e) {
            if (MessageBox.Show(this, "本当に、削除しますか。", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != System.Windows.Forms.DialogResult.Yes)
                return;

            bool any = false;
            foreach (var lvi in lvW.SelectedItems.Cast<ListViewItem>()) {
                var psi = new ProcessStartInfo("netsh.exe", " wlan delete profile name=\"" + lvi.Text + "\" ");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                var p = Process.Start(psi);
                p.WaitForExit();
                any |= p.ExitCode == 0;
            }

            if (any) Upd();
        }
    }
}
