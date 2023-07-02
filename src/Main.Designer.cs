namespace AutoKernels
{
    partial class Main
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
            menuStripMain = new MenuStrip();
            statusStripMain = new StatusStrip();
            splitContainerTop = new SplitContainer();
            tableLayoutPanelPlan = new TableLayoutPanel();
            groupBoxStep = new GroupBox();
            splitContainerStep = new SplitContainer();
            listViewStep = new ListView();
            Skill = new ColumnHeader();
            Description = new ColumnHeader();
            buttonRun = new Button();
            groupBoxPlan = new GroupBox();
            splitContainerPlan = new SplitContainer();
            textBoxPlan = new TextBox();
            textBoxPlanStatus = new TextBox();
            labelPlanStatus = new Label();
            buttonPlan = new Button();
            splitContainerResult = new SplitContainer();
            groupBoxResult = new GroupBox();
            richTextBoxResult = new RichTextBox();
            groupBoxChat = new GroupBox();
            splitContainerChat = new SplitContainer();
            textBoxChatOutput = new TextBox();
            buttonChatSend = new Button();
            textBoxChatInput = new TextBox();
            groupBoxLog = new GroupBox();
            textBoxLog = new TextBox();
            tableLayoutPanelTop = new TableLayoutPanel();
            toolStripMain = new ToolStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainerTop).BeginInit();
            splitContainerTop.Panel1.SuspendLayout();
            splitContainerTop.Panel2.SuspendLayout();
            splitContainerTop.SuspendLayout();
            tableLayoutPanelPlan.SuspendLayout();
            groupBoxStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerStep).BeginInit();
            splitContainerStep.Panel1.SuspendLayout();
            splitContainerStep.Panel2.SuspendLayout();
            splitContainerStep.SuspendLayout();
            groupBoxPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerPlan).BeginInit();
            splitContainerPlan.Panel1.SuspendLayout();
            splitContainerPlan.Panel2.SuspendLayout();
            splitContainerPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerResult).BeginInit();
            splitContainerResult.Panel1.SuspendLayout();
            splitContainerResult.Panel2.SuspendLayout();
            splitContainerResult.SuspendLayout();
            groupBoxResult.SuspendLayout();
            groupBoxChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerChat).BeginInit();
            splitContainerChat.Panel1.SuspendLayout();
            splitContainerChat.Panel2.SuspendLayout();
            splitContainerChat.SuspendLayout();
            groupBoxLog.SuspendLayout();
            tableLayoutPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(1008, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // statusStripMain
            // 
            statusStripMain.Location = new Point(0, 707);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(1008, 22);
            statusStripMain.TabIndex = 1;
            statusStripMain.Text = "statusStrip1";
            // 
            // splitContainerTop
            // 
            splitContainerTop.BorderStyle = BorderStyle.FixedSingle;
            splitContainerTop.Dock = DockStyle.Fill;
            splitContainerTop.Location = new Point(3, 32);
            splitContainerTop.Name = "splitContainerTop";
            // 
            // splitContainerTop.Panel1
            // 
            splitContainerTop.Panel1.Controls.Add(tableLayoutPanelPlan);
            // 
            // splitContainerTop.Panel2
            // 
            splitContainerTop.Panel2.Controls.Add(splitContainerResult);
            splitContainerTop.Size = new Size(737, 494);
            splitContainerTop.SplitterDistance = 356;
            splitContainerTop.TabIndex = 2;
            // 
            // tableLayoutPanelPlan
            // 
            tableLayoutPanelPlan.ColumnCount = 1;
            tableLayoutPanelPlan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelPlan.Controls.Add(groupBoxStep, 0, 1);
            tableLayoutPanelPlan.Controls.Add(groupBoxPlan, 0, 0);
            tableLayoutPanelPlan.Dock = DockStyle.Fill;
            tableLayoutPanelPlan.Location = new Point(0, 0);
            tableLayoutPanelPlan.Name = "tableLayoutPanelPlan";
            tableLayoutPanelPlan.RowCount = 2;
            tableLayoutPanelPlan.RowStyles.Add(new RowStyle(SizeType.Percent, 48.9583321F));
            tableLayoutPanelPlan.RowStyles.Add(new RowStyle(SizeType.Percent, 51.0416679F));
            tableLayoutPanelPlan.Size = new Size(354, 492);
            tableLayoutPanelPlan.TabIndex = 0;
            // 
            // groupBoxStep
            // 
            groupBoxStep.AutoSize = true;
            groupBoxStep.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxStep.Controls.Add(splitContainerStep);
            groupBoxStep.Dock = DockStyle.Fill;
            groupBoxStep.Location = new Point(3, 243);
            groupBoxStep.Name = "groupBoxStep";
            groupBoxStep.Size = new Size(348, 246);
            groupBoxStep.TabIndex = 1;
            groupBoxStep.TabStop = false;
            groupBoxStep.Text = "Step";
            // 
            // splitContainerStep
            // 
            splitContainerStep.Dock = DockStyle.Fill;
            splitContainerStep.IsSplitterFixed = true;
            splitContainerStep.Location = new Point(3, 19);
            splitContainerStep.Name = "splitContainerStep";
            splitContainerStep.Orientation = Orientation.Horizontal;
            // 
            // splitContainerStep.Panel1
            // 
            splitContainerStep.Panel1.Controls.Add(listViewStep);
            // 
            // splitContainerStep.Panel2
            // 
            splitContainerStep.Panel2.Controls.Add(buttonRun);
            splitContainerStep.Size = new Size(342, 224);
            splitContainerStep.SplitterDistance = 195;
            splitContainerStep.TabIndex = 0;
            // 
            // listViewStep
            // 
            listViewStep.Columns.AddRange(new ColumnHeader[] { Skill, Description });
            listViewStep.Dock = DockStyle.Fill;
            listViewStep.GridLines = true;
            listViewStep.Location = new Point(0, 0);
            listViewStep.MultiSelect = false;
            listViewStep.Name = "listViewStep";
            listViewStep.Size = new Size(342, 195);
            listViewStep.TabIndex = 0;
            listViewStep.TabStop = false;
            listViewStep.UseCompatibleStateImageBehavior = false;
            listViewStep.View = View.Details;
            // 
            // Skill
            // 
            Skill.Text = "Skill";
            Skill.Width = 64;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 360;
            // 
            // buttonRun
            // 
            buttonRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRun.Location = new Point(264, -1);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(75, 23);
            buttonRun.TabIndex = 3;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += OnClickRun;
            // 
            // groupBoxPlan
            // 
            groupBoxPlan.AutoSize = true;
            groupBoxPlan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxPlan.Controls.Add(splitContainerPlan);
            groupBoxPlan.Dock = DockStyle.Fill;
            groupBoxPlan.Location = new Point(3, 3);
            groupBoxPlan.Name = "groupBoxPlan";
            groupBoxPlan.Size = new Size(348, 234);
            groupBoxPlan.TabIndex = 0;
            groupBoxPlan.TabStop = false;
            groupBoxPlan.Text = "Plan";
            // 
            // splitContainerPlan
            // 
            splitContainerPlan.Dock = DockStyle.Fill;
            splitContainerPlan.IsSplitterFixed = true;
            splitContainerPlan.Location = new Point(3, 19);
            splitContainerPlan.Name = "splitContainerPlan";
            splitContainerPlan.Orientation = Orientation.Horizontal;
            // 
            // splitContainerPlan.Panel1
            // 
            splitContainerPlan.Panel1.Controls.Add(textBoxPlan);
            // 
            // splitContainerPlan.Panel2
            // 
            splitContainerPlan.Panel2.Controls.Add(textBoxPlanStatus);
            splitContainerPlan.Panel2.Controls.Add(labelPlanStatus);
            splitContainerPlan.Panel2.Controls.Add(buttonPlan);
            splitContainerPlan.Size = new Size(342, 212);
            splitContainerPlan.SplitterDistance = 183;
            splitContainerPlan.TabIndex = 0;
            // 
            // textBoxPlan
            // 
            textBoxPlan.Location = new Point(0, 87);
            textBoxPlan.Multiline = true;
            textBoxPlan.Name = "textBoxPlan";
            textBoxPlan.Size = new Size(362, 102);
            textBoxPlan.TabIndex = 1;
            // 
            // textBoxPlanStatus
            // 
            textBoxPlanStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxPlanStatus.BackColor = SystemColors.Control;
            textBoxPlanStatus.ImeMode = ImeMode.Off;
            textBoxPlanStatus.Location = new Point(44, -1);
            textBoxPlanStatus.Name = "textBoxPlanStatus";
            textBoxPlanStatus.ReadOnly = true;
            textBoxPlanStatus.Size = new Size(230, 23);
            textBoxPlanStatus.TabIndex = 0;
            textBoxPlanStatus.TabStop = false;
            // 
            // labelPlanStatus
            // 
            labelPlanStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPlanStatus.AutoSize = true;
            labelPlanStatus.Location = new Point(3, 4);
            labelPlanStatus.Name = "labelPlanStatus";
            labelPlanStatus.Size = new Size(42, 15);
            labelPlanStatus.TabIndex = 0;
            labelPlanStatus.Text = "Status:";
            // 
            // buttonPlan
            // 
            buttonPlan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPlan.Location = new Point(260, -1);
            buttonPlan.Name = "buttonPlan";
            buttonPlan.Size = new Size(79, 24);
            buttonPlan.TabIndex = 2;
            buttonPlan.Text = "Plan";
            buttonPlan.UseVisualStyleBackColor = true;
            buttonPlan.Click += OnClickPlan;
            // 
            // splitContainerResult
            // 
            splitContainerResult.Location = new Point(14, 43);
            splitContainerResult.Name = "splitContainerResult";
            // 
            // splitContainerResult.Panel1
            // 
            splitContainerResult.Panel1.Controls.Add(groupBoxResult);
            // 
            // splitContainerResult.Panel2
            // 
            splitContainerResult.Panel2.Controls.Add(groupBoxChat);
            splitContainerResult.Size = new Size(332, 414);
            splitContainerResult.SplitterDistance = 166;
            splitContainerResult.TabIndex = 1;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(richTextBoxResult);
            groupBoxResult.Dock = DockStyle.Fill;
            groupBoxResult.Location = new Point(0, 0);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(166, 414);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Result";
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.BackColor = SystemColors.Window;
            richTextBoxResult.Dock = DockStyle.Fill;
            richTextBoxResult.Location = new Point(3, 19);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.ReadOnly = true;
            richTextBoxResult.Size = new Size(160, 392);
            richTextBoxResult.TabIndex = 0;
            richTextBoxResult.TabStop = false;
            richTextBoxResult.Text = "";
            // 
            // groupBoxChat
            // 
            groupBoxChat.Controls.Add(splitContainerChat);
            groupBoxChat.Dock = DockStyle.Fill;
            groupBoxChat.Location = new Point(0, 0);
            groupBoxChat.Name = "groupBoxChat";
            groupBoxChat.Size = new Size(162, 414);
            groupBoxChat.TabIndex = 0;
            groupBoxChat.TabStop = false;
            groupBoxChat.Text = "Chat";
            // 
            // splitContainerChat
            // 
            splitContainerChat.Dock = DockStyle.Fill;
            splitContainerChat.Location = new Point(3, 19);
            splitContainerChat.Name = "splitContainerChat";
            splitContainerChat.Orientation = Orientation.Horizontal;
            // 
            // splitContainerChat.Panel1
            // 
            splitContainerChat.Panel1.Controls.Add(textBoxChatOutput);
            // 
            // splitContainerChat.Panel2
            // 
            splitContainerChat.Panel2.Controls.Add(buttonChatSend);
            splitContainerChat.Panel2.Controls.Add(textBoxChatInput);
            splitContainerChat.Size = new Size(156, 392);
            splitContainerChat.SplitterDistance = 321;
            splitContainerChat.TabIndex = 0;
            // 
            // textBoxChatOutput
            // 
            textBoxChatOutput.BackColor = SystemColors.Window;
            textBoxChatOutput.Location = new Point(12, 14);
            textBoxChatOutput.Multiline = true;
            textBoxChatOutput.Name = "textBoxChatOutput";
            textBoxChatOutput.ReadOnly = true;
            textBoxChatOutput.Size = new Size(128, 261);
            textBoxChatOutput.TabIndex = 0;
            // 
            // buttonChatSend
            // 
            buttonChatSend.Location = new Point(100, 38);
            buttonChatSend.Name = "buttonChatSend";
            buttonChatSend.Size = new Size(53, 26);
            buttonChatSend.TabIndex = 1;
            buttonChatSend.Text = "Send";
            buttonChatSend.UseVisualStyleBackColor = true;
            buttonChatSend.Click += OnClickChatSend;
            // 
            // textBoxChatInput
            // 
            textBoxChatInput.Location = new Point(3, 3);
            textBoxChatInput.Multiline = true;
            textBoxChatInput.Name = "textBoxChatInput";
            textBoxChatInput.Size = new Size(137, 33);
            textBoxChatInput.TabIndex = 0;
            // 
            // groupBoxLog
            // 
            groupBoxLog.Controls.Add(textBoxLog);
            groupBoxLog.Dock = DockStyle.Fill;
            groupBoxLog.Location = new Point(3, 532);
            groupBoxLog.Name = "groupBoxLog";
            groupBoxLog.Size = new Size(737, 96);
            groupBoxLog.TabIndex = 3;
            groupBoxLog.TabStop = false;
            groupBoxLog.Text = "Log";
            // 
            // textBoxLog
            // 
            textBoxLog.BackColor = SystemColors.Control;
            textBoxLog.Dock = DockStyle.Fill;
            textBoxLog.ImeMode = ImeMode.Off;
            textBoxLog.Location = new Point(3, 19);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ReadOnly = true;
            textBoxLog.ScrollBars = ScrollBars.Both;
            textBoxLog.Size = new Size(731, 74);
            textBoxLog.TabIndex = 0;
            textBoxLog.TabStop = false;
            textBoxLog.WordWrap = false;
            // 
            // tableLayoutPanelTop
            // 
            tableLayoutPanelTop.ColumnCount = 1;
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTop.Controls.Add(splitContainerTop, 0, 1);
            tableLayoutPanelTop.Controls.Add(toolStripMain, 0, 0);
            tableLayoutPanelTop.Controls.Add(groupBoxLog, 0, 2);
            tableLayoutPanelTop.Location = new Point(12, 36);
            tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            tableLayoutPanelTop.RowCount = 3;
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 5.581395F));
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 94.4186F));
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
            tableLayoutPanelTop.Size = new Size(743, 631);
            tableLayoutPanelTop.TabIndex = 4;
            // 
            // toolStripMain
            // 
            toolStripMain.Location = new Point(0, 0);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Size = new Size(743, 25);
            toolStripMain.TabIndex = 1;
            toolStripMain.Text = "toolStrip1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(tableLayoutPanelTop);
            Controls.Add(statusStripMain);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "Main";
            Text = "AutoKernels";
            FormClosed += OnClosed;
            Load += OnLoad;
            splitContainerTop.Panel1.ResumeLayout(false);
            splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerTop).EndInit();
            splitContainerTop.ResumeLayout(false);
            tableLayoutPanelPlan.ResumeLayout(false);
            tableLayoutPanelPlan.PerformLayout();
            groupBoxStep.ResumeLayout(false);
            splitContainerStep.Panel1.ResumeLayout(false);
            splitContainerStep.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerStep).EndInit();
            splitContainerStep.ResumeLayout(false);
            groupBoxPlan.ResumeLayout(false);
            splitContainerPlan.Panel1.ResumeLayout(false);
            splitContainerPlan.Panel1.PerformLayout();
            splitContainerPlan.Panel2.ResumeLayout(false);
            splitContainerPlan.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerPlan).EndInit();
            splitContainerPlan.ResumeLayout(false);
            splitContainerResult.Panel1.ResumeLayout(false);
            splitContainerResult.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerResult).EndInit();
            splitContainerResult.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxChat.ResumeLayout(false);
            splitContainerChat.Panel1.ResumeLayout(false);
            splitContainerChat.Panel1.PerformLayout();
            splitContainerChat.Panel2.ResumeLayout(false);
            splitContainerChat.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerChat).EndInit();
            splitContainerChat.ResumeLayout(false);
            groupBoxLog.ResumeLayout(false);
            groupBoxLog.PerformLayout();
            tableLayoutPanelTop.ResumeLayout(false);
            tableLayoutPanelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private StatusStrip statusStripMain;
        private SplitContainer splitContainerTop;
        private TextBox textBoxPlan;
        private Button buttonPlan;
        private TableLayoutPanel tableLayoutPanelPlan;
        private GroupBox groupBoxStep;
        private GroupBox groupBoxPlan;
        private ListView listViewStep;
        private ColumnHeader Skill;
        private ColumnHeader Description;
        private SplitContainer splitContainerPlan;
        private SplitContainer splitContainerStep;
        private Button buttonRun;
        private GroupBox groupBoxLog;
        private TextBox textBoxLog;
        private RichTextBox richTextBoxResult;
        private Label labelPlanStatus;
        private TextBox textBoxPlanStatus;
        private TableLayoutPanel tableLayoutPanelTop;
        private ToolStrip toolStripMain;
        private SplitContainer splitContainerResult;
        private SplitContainer splitContainerChat;
        private GroupBox groupBoxResult;
        private GroupBox groupBoxChat;
        private TextBox textBoxChatOutput;
        private TextBox textBoxChatInput;
        private Button buttonChatSend;
    }
}