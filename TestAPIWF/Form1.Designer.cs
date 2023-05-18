namespace TestAPIWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.tbt_money = new System.Windows.Forms.TextBox();
            this.tbt_day = new System.Windows.Forms.TextBox();
            this.tbt_percent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_confirm.Location = new System.Drawing.Point(21, 219);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(278, 67);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "Tiền Báo";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_result.Location = new System.Drawing.Point(334, 219);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(550, 67);
            this.btn_result.TabIndex = 1;
            this.btn_result.Text = "...";
            this.btn_result.UseVisualStyleBackColor = true;
            // 
            // tbt_money
            // 
            this.tbt_money.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_money.Location = new System.Drawing.Point(334, 11);
            this.tbt_money.Name = "tbt_money";
            this.tbt_money.Size = new System.Drawing.Size(550, 43);
            this.tbt_money.TabIndex = 2;
            // 
            // tbt_day
            // 
            this.tbt_day.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_day.Location = new System.Drawing.Point(334, 79);
            this.tbt_day.Name = "tbt_day";
            this.tbt_day.Size = new System.Drawing.Size(550, 43);
            this.tbt_day.TabIndex = 3;
            // 
            // tbt_percent
            // 
            this.tbt_percent.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_percent.Location = new System.Drawing.Point(334, 144);
            this.tbt_percent.Name = "tbt_percent";
            this.tbt_percent.Size = new System.Drawing.Size(550, 43);
            this.tbt_percent.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập số tiền bạn vay";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập số ngày bạn nợ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập lãi suất bạn chịu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(908, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbt_percent);
            this.Controls.Add(this.tbt_day);
            this.Controls.Add(this.tbt_money);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_confirm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_confirm;
        private Button btn_result;
        private TextBox tbt_money;
        private TextBox tbt_day;
        private TextBox tbt_percent;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}