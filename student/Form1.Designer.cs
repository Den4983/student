
namespace student
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnGetGr = new System.Windows.Forms.Button();
            this.btnGetSt = new System.Windows.Forms.Button();
            this.btnInsSt = new System.Windows.Forms.Button();
            this.UpdSt = new System.Windows.Forms.Button();
            this.btnDelSt = new System.Windows.Forms.Button();
            this.btnDelGr = new System.Windows.Forms.Button();
            this.btnUpdGr = new System.Windows.Forms.Button();
            this.btnInsGr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "AddDB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 12);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(661, 271);
            this.dgvMain.TabIndex = 1;
            // 
            // btnGetGr
            // 
            this.btnGetGr.Location = new System.Drawing.Point(93, 289);
            this.btnGetGr.Name = "btnGetGr";
            this.btnGetGr.Size = new System.Drawing.Size(75, 23);
            this.btnGetGr.TabIndex = 2;
            this.btnGetGr.Text = "GetGr";
            this.btnGetGr.UseVisualStyleBackColor = true;
            this.btnGetGr.Click += new System.EventHandler(this.btnGetGr_Click);
            // 
            // btnGetSt
            // 
            this.btnGetSt.Location = new System.Drawing.Point(12, 289);
            this.btnGetSt.Name = "btnGetSt";
            this.btnGetSt.Size = new System.Drawing.Size(75, 23);
            this.btnGetSt.TabIndex = 3;
            this.btnGetSt.Text = "GetSt";
            this.btnGetSt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGetSt.UseVisualStyleBackColor = true;
            this.btnGetSt.Click += new System.EventHandler(this.btnGetSt_Click);
            // 
            // btnInsSt
            // 
            this.btnInsSt.Location = new System.Drawing.Point(12, 357);
            this.btnInsSt.Name = "btnInsSt";
            this.btnInsSt.Size = new System.Drawing.Size(75, 23);
            this.btnInsSt.TabIndex = 4;
            this.btnInsSt.Text = "InsSt";
            this.btnInsSt.UseVisualStyleBackColor = true;
            this.btnInsSt.Click += new System.EventHandler(this.btnInsSt_Click);
            // 
            // UpdSt
            // 
            this.UpdSt.Location = new System.Drawing.Point(12, 386);
            this.UpdSt.Name = "UpdSt";
            this.UpdSt.Size = new System.Drawing.Size(75, 23);
            this.UpdSt.TabIndex = 5;
            this.UpdSt.Text = "UpdSt";
            this.UpdSt.UseVisualStyleBackColor = true;
            this.UpdSt.Click += new System.EventHandler(this.UpdSt_Click);
            // 
            // btnDelSt
            // 
            this.btnDelSt.Location = new System.Drawing.Point(12, 415);
            this.btnDelSt.Name = "btnDelSt";
            this.btnDelSt.Size = new System.Drawing.Size(75, 23);
            this.btnDelSt.TabIndex = 6;
            this.btnDelSt.Text = "DelSt";
            this.btnDelSt.UseVisualStyleBackColor = true;
            this.btnDelSt.Click += new System.EventHandler(this.btnDelSt_Click);
            // 
            // btnDelGr
            // 
            this.btnDelGr.Location = new System.Drawing.Point(226, 415);
            this.btnDelGr.Name = "btnDelGr";
            this.btnDelGr.Size = new System.Drawing.Size(75, 23);
            this.btnDelGr.TabIndex = 9;
            this.btnDelGr.Text = "DelGr";
            this.btnDelGr.UseVisualStyleBackColor = true;
            this.btnDelGr.Click += new System.EventHandler(this.btnDelGr_Click);
            // 
            // btnUpdGr
            // 
            this.btnUpdGr.Location = new System.Drawing.Point(226, 386);
            this.btnUpdGr.Name = "btnUpdGr";
            this.btnUpdGr.Size = new System.Drawing.Size(75, 23);
            this.btnUpdGr.TabIndex = 8;
            this.btnUpdGr.Text = "UpdGr";
            this.btnUpdGr.UseVisualStyleBackColor = true;
            this.btnUpdGr.Click += new System.EventHandler(this.btnUpdGr_Click);
            // 
            // btnInsGr
            // 
            this.btnInsGr.Location = new System.Drawing.Point(226, 357);
            this.btnInsGr.Name = "btnInsGr";
            this.btnInsGr.Size = new System.Drawing.Size(75, 23);
            this.btnInsGr.TabIndex = 7;
            this.btnInsGr.Text = "InsGr";
            this.btnInsGr.UseVisualStyleBackColor = true;
            this.btnInsGr.Click += new System.EventHandler(this.btnInsGr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelGr);
            this.Controls.Add(this.btnUpdGr);
            this.Controls.Add(this.btnInsGr);
            this.Controls.Add(this.btnDelSt);
            this.Controls.Add(this.UpdSt);
            this.Controls.Add(this.btnInsSt);
            this.Controls.Add(this.btnGetSt);
            this.Controls.Add(this.btnGetGr);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnGetGr;
        private System.Windows.Forms.Button btnGetSt;
        private System.Windows.Forms.Button btnInsSt;
        private System.Windows.Forms.Button UpdSt;
        private System.Windows.Forms.Button btnDelSt;
        private System.Windows.Forms.Button btnDelGr;
        private System.Windows.Forms.Button btnUpdGr;
        private System.Windows.Forms.Button btnInsGr;
    }
}

