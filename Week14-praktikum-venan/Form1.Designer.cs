namespace Week14_praktikum_venan
{
    partial class Form1
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
            this.btfirst = new System.Windows.Forms.Button();
            this.btprev = new System.Windows.Forms.Button();
            this.btlast = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.team = new System.Windows.Forms.Label();
            this.manager = new System.Windows.Forms.Label();
            this.stadium = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbname = new System.Windows.Forms.Label();
            this.lbmanager = new System.Windows.Forms.Label();
            this.lbstadium = new System.Windows.Forms.Label();
            this.lbscore = new System.Windows.Forms.Label();
            this.lbworst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btfirst
            // 
            this.btfirst.Location = new System.Drawing.Point(22, 21);
            this.btfirst.Name = "btfirst";
            this.btfirst.Size = new System.Drawing.Size(111, 36);
            this.btfirst.TabIndex = 0;
            this.btfirst.Text = "<<";
            this.btfirst.UseVisualStyleBackColor = true;
            this.btfirst.Click += new System.EventHandler(this.btfirst_Click);
            // 
            // btprev
            // 
            this.btprev.Location = new System.Drawing.Point(139, 21);
            this.btprev.Name = "btprev";
            this.btprev.Size = new System.Drawing.Size(111, 36);
            this.btprev.TabIndex = 1;
            this.btprev.Text = "<";
            this.btprev.UseVisualStyleBackColor = true;
            this.btprev.Click += new System.EventHandler(this.btprev_Click);
            // 
            // btlast
            // 
            this.btlast.Location = new System.Drawing.Point(403, 21);
            this.btlast.Name = "btlast";
            this.btlast.Size = new System.Drawing.Size(111, 36);
            this.btlast.TabIndex = 3;
            this.btlast.Text = ">>";
            this.btlast.UseVisualStyleBackColor = true;
            this.btlast.Click += new System.EventHandler(this.btlast_Click);
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(286, 21);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(111, 36);
            this.btnext.TabIndex = 2;
            this.btnext.Text = ">";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // team
            // 
            this.team.AutoSize = true;
            this.team.Location = new System.Drawing.Point(30, 87);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(103, 20);
            this.team.TabIndex = 4;
            this.team.Text = "Team Name :";
            this.team.Click += new System.EventHandler(this.team_Click);
            // 
            // manager
            // 
            this.manager.AutoSize = true;
            this.manager.Location = new System.Drawing.Point(53, 123);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(80, 20);
            this.manager.TabIndex = 5;
            this.manager.Text = "Manager :";
            // 
            // stadium
            // 
            this.stadium.AutoSize = true;
            this.stadium.Location = new System.Drawing.Point(57, 158);
            this.stadium.Name = "stadium";
            this.stadium.Size = new System.Drawing.Size(76, 20);
            this.stadium.TabIndex = 6;
            this.stadium.Text = "Stadium :";
            // 
            // goal
            // 
            this.goal.AutoSize = true;
            this.goal.Location = new System.Drawing.Point(38, 190);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(95, 20);
            this.goal.TabIndex = 7;
            this.goal.Text = "Top Scorer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Worst Discipline :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(499, 171);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(162, 87);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(18, 20);
            this.lbname.TabIndex = 10;
            this.lbname.Text = "1";
            // 
            // lbmanager
            // 
            this.lbmanager.AutoSize = true;
            this.lbmanager.Location = new System.Drawing.Point(162, 123);
            this.lbmanager.Name = "lbmanager";
            this.lbmanager.Size = new System.Drawing.Size(18, 20);
            this.lbmanager.TabIndex = 11;
            this.lbmanager.Text = "2";
            // 
            // lbstadium
            // 
            this.lbstadium.AutoSize = true;
            this.lbstadium.Location = new System.Drawing.Point(162, 158);
            this.lbstadium.Name = "lbstadium";
            this.lbstadium.Size = new System.Drawing.Size(18, 20);
            this.lbstadium.TabIndex = 12;
            this.lbstadium.Text = "3";
            // 
            // lbscore
            // 
            this.lbscore.AutoSize = true;
            this.lbscore.Location = new System.Drawing.Point(162, 190);
            this.lbscore.Name = "lbscore";
            this.lbscore.Size = new System.Drawing.Size(18, 20);
            this.lbscore.TabIndex = 13;
            this.lbscore.Text = "4";
            // 
            // lbworst
            // 
            this.lbworst.AutoSize = true;
            this.lbworst.Location = new System.Drawing.Point(162, 220);
            this.lbworst.Name = "lbworst";
            this.lbworst.Size = new System.Drawing.Size(18, 20);
            this.lbworst.TabIndex = 14;
            this.lbworst.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.lbworst);
            this.Controls.Add(this.lbscore);
            this.Controls.Add(this.lbstadium);
            this.Controls.Add(this.lbmanager);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.stadium);
            this.Controls.Add(this.manager);
            this.Controls.Add(this.team);
            this.Controls.Add(this.btlast);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.btprev);
            this.Controls.Add(this.btfirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btfirst;
        private System.Windows.Forms.Button btprev;
        private System.Windows.Forms.Button btlast;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Label team;
        private System.Windows.Forms.Label manager;
        private System.Windows.Forms.Label stadium;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbmanager;
        private System.Windows.Forms.Label lbstadium;
        private System.Windows.Forms.Label lbscore;
        private System.Windows.Forms.Label lbworst;
    }
}

