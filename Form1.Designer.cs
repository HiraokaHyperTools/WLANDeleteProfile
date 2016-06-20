namespace WLANDeleteProfile {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lvW = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAuth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsW = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsW.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvW
            // 
            this.lvW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chSSID,
            this.chAuth});
            this.lvW.ContextMenuStrip = this.cmsW;
            this.lvW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvW.FullRowSelect = true;
            this.lvW.GridLines = true;
            this.lvW.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvW.Location = new System.Drawing.Point(0, 0);
            this.lvW.Name = "lvW";
            this.lvW.Size = new System.Drawing.Size(716, 469);
            this.lvW.TabIndex = 0;
            this.lvW.UseCompatibleStateImageBehavior = false;
            this.lvW.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "名称";
            this.chName.Width = 250;
            // 
            // chSSID
            // 
            this.chSSID.Text = "SSID";
            this.chSSID.Width = 250;
            // 
            // chAuth
            // 
            this.chAuth.Text = "認証";
            this.chAuth.Width = 150;
            // 
            // cmsW
            // 
            this.cmsW.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mRemove});
            this.cmsW.Name = "cmsW";
            this.cmsW.Size = new System.Drawing.Size(118, 26);
            // 
            // mRemove
            // 
            this.mRemove.Name = "mRemove";
            this.mRemove.Size = new System.Drawing.Size(117, 22);
            this.mRemove.Text = "削除する";
            this.mRemove.Click += new System.EventHandler(this.mRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 469);
            this.Controls.Add(this.lvW);
            this.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WLANDeleteProfile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsW.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvW;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSSID;
        private System.Windows.Forms.ColumnHeader chAuth;
        private System.Windows.Forms.ContextMenuStrip cmsW;
        private System.Windows.Forms.ToolStripMenuItem mRemove;


    }
}

