
namespace 幸运者抽奖
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txLuck = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_refreash = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.tx_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_show = new System.Windows.Forms.RichTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lb_systemtime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txLuck
            // 
            this.txLuck.Font = new System.Drawing.Font("宋体", 20F);
            this.txLuck.Location = new System.Drawing.Point(29, 91);
            this.txLuck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txLuck.Name = "txLuck";
            this.txLuck.PasswordChar = '*';
            this.txLuck.Size = new System.Drawing.Size(329, 46);
            this.txLuck.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(29, 181);
            this.button_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(131, 99);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(224, 181);
            this.button_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(131, 99);
            this.button_stop.TabIndex = 2;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "幸运观众";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(29, 376);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(109, 48);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(161, 376);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(109, 48);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_refreash
            // 
            this.button_refreash.Location = new System.Drawing.Point(29, 442);
            this.button_refreash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_refreash.Name = "button_refreash";
            this.button_refreash.Size = new System.Drawing.Size(109, 48);
            this.button_refreash.TabIndex = 5;
            this.button_refreash.Text = "刷新";
            this.button_refreash.UseVisualStyleBackColor = true;
            this.button_refreash.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(161, 442);
            this.button_about.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(109, 48);
            this.button_about.TabIndex = 5;
            this.button_about.Text = "关于";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // tx_input
            // 
            this.tx_input.Location = new System.Drawing.Point(29, 299);
            this.tx_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_input.Name = "tx_input";
            this.tx_input.Size = new System.Drawing.Size(252, 25);
            this.tx_input.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(771, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "仅供自用";
            // 
            // richTextBox_show
            // 
            this.richTextBox_show.Location = new System.Drawing.Point(367, 91);
            this.richTextBox_show.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_show.Name = "richTextBox_show";
            this.richTextBox_show.Size = new System.Drawing.Size(283, 313);
            this.richTextBox_show.TabIndex = 9;
            this.richTextBox_show.Text = "";
            this.richTextBox_show.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "时间显示：";
            // 
            // lb_systemtime
            // 
            this.lb_systemtime.AutoSize = true;
            this.lb_systemtime.Location = new System.Drawing.Point(123, 19);
            this.lb_systemtime.Name = "lb_systemtime";
            this.lb_systemtime.Size = new System.Drawing.Size(67, 15);
            this.lb_systemtime.TabIndex = 11;
            this.lb_systemtime.Text = "显示时间";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 520);
            this.Controls.Add(this.lb_systemtime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_input);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_refreash);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.txLuck);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "抽奖";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txLuck;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_refreash;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.TextBox tx_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_show;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_systemtime;
    }
}

