namespace Client
{
    partial class HarmaSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRawData = new System.Windows.Forms.DataGridView();
            this.bLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRawData
            // 
            this.dgvRawData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRawData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawData.Location = new System.Drawing.Point(12, 55);
            this.dgvRawData.Name = "dgvRawData";
            this.dgvRawData.Size = new System.Drawing.Size(670, 383);
            this.dgvRawData.TabIndex = 0;
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(560, 12);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(122, 23);
            this.bLoad.TabIndex = 1;
            this.bLoad.Text = "Load test data";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.On_bLoadClick);
            // 
            // HarmaSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.dgvRawData);
            this.Name = "HarmaSearch";
            this.Text = "Список предприятий";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRawData;
        private System.Windows.Forms.Button bLoad;
    }
}

