﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TTSDanmakuMgmt
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TTSDanmakuMgmt))
        Me.StatusStrip_Main = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel_Default = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox_TTSOptions = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_RetryCount = New System.Windows.Forms.NumericUpDown()
        Me.Label_RetryCount = New System.Windows.Forms.Label()
        Me.TextBox_CustomConnected = New System.Windows.Forms.TextBox()
        Me.Label_CustomConnected = New System.Windows.Forms.Label()
        Me.CheckBox_NoKeepingCache = New System.Windows.Forms.CheckBox()
        Me.Button_SetupWizard = New System.Windows.Forms.Button()
        Me.NumericUpDown_Volume = New System.Windows.Forms.NumericUpDown()
        Me.Label_TTSVolume = New System.Windows.Forms.Label()
        Me.Button_StatusReport = New System.Windows.Forms.Button()
        Me.ComboBox_Engine = New System.Windows.Forms.ComboBox()
        Me.Label_SpeechEngine = New System.Windows.Forms.Label()
        Me.TextBox_CustomGiftContent = New System.Windows.Forms.TextBox()
        Me.TextBox_CustomDMContent = New System.Windows.Forms.TextBox()
        Me.Label_CustomGiftContent_Header = New System.Windows.Forms.Label()
        Me.Label_CustomDM_Header = New System.Windows.Forms.Label()
        Me.NumericUpDown_CoolDownValue = New System.Windows.Forms.NumericUpDown()
        Me.Label_Value_Prefix = New System.Windows.Forms.Label()
        Me.CheckBox_TTSCoolDown = New System.Windows.Forms.CheckBox()
        Me.CheckBox_NoCache = New System.Windows.Forms.CheckBox()
        Me.Button_Load = New System.Windows.Forms.Button()
        Me.Button_Apply = New System.Windows.Forms.Button()
        Me.CheckBox_TTSGifts = New System.Windows.Forms.CheckBox()
        Me.CheckBox_TTSSender = New System.Windows.Forms.CheckBox()
        Me.CheckBox_TTSDebug = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Statistics = New System.Windows.Forms.GroupBox()
        Me.TextBox_Stats = New System.Windows.Forms.TextBox()
        Me.GroupBox_TempMgr = New System.Windows.Forms.GroupBox()
        Me.Button_DeleteAll = New System.Windows.Forms.Button()
        Me.TextBox_Files = New System.Windows.Forms.TextBox()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Reload = New System.Windows.Forms.Button()
        Me.LinkLabel_About = New System.Windows.Forms.LinkLabel()
        Me.ToolTip_Default = New System.Windows.Forms.ToolTip(Me.components)
        Me.LinkLabel_Suggestions = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_FAQ = New System.Windows.Forms.LinkLabel()
        Me.Label_ThanksViaMyHeart = New System.Windows.Forms.Label()
        Me.Button_CheckUpdates = New System.Windows.Forms.Button()
        Me.StatusStrip_Main.SuspendLayout()
        Me.GroupBox_TTSOptions.SuspendLayout()
        CType(Me.NumericUpDown_RetryCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_CoolDownValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Statistics.SuspendLayout()
        Me.GroupBox_TempMgr.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip_Main
        '
        Me.StatusStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel_Default})
        Me.StatusStrip_Main.Location = New System.Drawing.Point(0, 630)
        Me.StatusStrip_Main.Name = "StatusStrip_Main"
        Me.StatusStrip_Main.Size = New System.Drawing.Size(684, 22)
        Me.StatusStrip_Main.TabIndex = 9
        Me.StatusStrip_Main.Text = "Status Bar"
        '
        'StatusLabel_Default
        '
        Me.StatusLabel_Default.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel_Default.Name = "StatusLabel_Default"
        Me.StatusLabel_Default.Size = New System.Drawing.Size(32, 17)
        Me.StatusLabel_Default.Text = "就绪"
        '
        'GroupBox_TTSOptions
        '
        Me.GroupBox_TTSOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_TTSOptions.Controls.Add(Me.Button_CheckUpdates)
        Me.GroupBox_TTSOptions.Controls.Add(Me.NumericUpDown_RetryCount)
        Me.GroupBox_TTSOptions.Controls.Add(Me.Label_RetryCount)
        Me.GroupBox_TTSOptions.Controls.Add(Me.TextBox_CustomConnected)
        Me.GroupBox_TTSOptions.Controls.Add(Me.Label_CustomConnected)
        Me.GroupBox_TTSOptions.Controls.Add(Me.CheckBox_NoKeepingCache)
        Me.GroupBox_TTSOptions.Controls.Add(Me.Button_SetupWizard)
        Me.GroupBox_TTSOptions.Controls.Add(Me.NumericUpDown_Volume)
        Me.GroupBox_TTSOptions.Controls.Add(Me.Label_TTSVolume)
        Me.GroupBox_TTSOptions.Controls.Add(Me.Button_StatusReport)
        Me.GroupBox_TTSOptions.Controls.Add(Me.ComboBox_Engine)
        Me.GroupBox_TTSOptions.Controls.Add(Me.Label_SpeechEngine)
        Me.GroupBox_TTSOptions.Controls.Add(Me.TextBox_CustomGiftContent)
        Me.GroupBox_TTSOptions.Controls.Add(Me.TextBox_CustomDMContent)
        Me.GroupBox_TTSOptions.Controls.Add(Me.Label_CustomGiftContent_Header)
        Me.GroupBox_TTSOptions.Controls.Add(Me.Label_CustomDM_Header)
        Me.GroupBox_TTSOptions.Controls.Add(Me.NumericUpDown_CoolDownValue)
        Me.GroupBox_TTSOptions.Controls.Add(Me.Label_Value_Prefix)
        Me.GroupBox_TTSOptions.Controls.Add(Me.CheckBox_TTSCoolDown)
        Me.GroupBox_TTSOptions.Controls.Add(Me.CheckBox_NoCache)
        Me.GroupBox_TTSOptions.Controls.Add(Me.Button_Load)
        Me.GroupBox_TTSOptions.Controls.Add(Me.Button_Apply)
        Me.GroupBox_TTSOptions.Controls.Add(Me.CheckBox_TTSGifts)
        Me.GroupBox_TTSOptions.Controls.Add(Me.CheckBox_TTSSender)
        Me.GroupBox_TTSOptions.Controls.Add(Me.CheckBox_TTSDebug)
        Me.GroupBox_TTSOptions.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox_TTSOptions.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox_TTSOptions.Name = "GroupBox_TTSOptions"
        Me.GroupBox_TTSOptions.Size = New System.Drawing.Size(660, 364)
        Me.GroupBox_TTSOptions.TabIndex = 0
        Me.GroupBox_TTSOptions.TabStop = False
        Me.GroupBox_TTSOptions.Text = "TTS 设置"
        '
        'NumericUpDown_RetryCount
        '
        Me.NumericUpDown_RetryCount.Location = New System.Drawing.Point(193, 138)
        Me.NumericUpDown_RetryCount.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_RetryCount.Name = "NumericUpDown_RetryCount"
        Me.NumericUpDown_RetryCount.Size = New System.Drawing.Size(137, 23)
        Me.NumericUpDown_RetryCount.TabIndex = 19
        Me.ToolTip_Default.SetToolTip(Me.NumericUpDown_RetryCount, "指定在下载 TTS 文件时出现网络错误的重试次数。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "默认值: 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "范围为 0 ~ 10, 指定为 0 将阻止插件重新下载。")
        '
        'Label_RetryCount
        '
        Me.Label_RetryCount.AutoSize = True
        Me.Label_RetryCount.Location = New System.Drawing.Point(190, 118)
        Me.Label_RetryCount.Name = "Label_RetryCount"
        Me.Label_RetryCount.Size = New System.Drawing.Size(166, 17)
        Me.Label_RetryCount.TabIndex = 18
        Me.Label_RetryCount.Text = "下载失败重试次数（0 ~ 10）"
        '
        'TextBox_CustomConnected
        '
        Me.TextBox_CustomConnected.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_CustomConnected.BackColor = System.Drawing.Color.LightGreen
        Me.TextBox_CustomConnected.Location = New System.Drawing.Point(6, 338)
        Me.TextBox_CustomConnected.Name = "TextBox_CustomConnected"
        Me.TextBox_CustomConnected.Size = New System.Drawing.Size(648, 23)
        Me.TextBox_CustomConnected.TabIndex = 13
        Me.ToolTip_Default.SetToolTip(Me.TextBox_CustomConnected, "指定插件检测到弹幕姬成功连接至房间时读出的内容。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "用 %s 来代替房间号。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "留空可关闭本功能。")
        '
        'Label_CustomConnected
        '
        Me.Label_CustomConnected.AutoSize = True
        Me.Label_CustomConnected.Location = New System.Drawing.Point(6, 318)
        Me.Label_CustomConnected.Name = "Label_CustomConnected"
        Me.Label_CustomConnected.Size = New System.Drawing.Size(164, 17)
        Me.Label_CustomConnected.TabIndex = 12
        Me.Label_CustomConnected.Text = "自定义房间连接成功读出内容"
        '
        'CheckBox_NoKeepingCache
        '
        Me.CheckBox_NoKeepingCache.AutoSize = True
        Me.CheckBox_NoKeepingCache.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_NoKeepingCache.Location = New System.Drawing.Point(6, 134)
        Me.CheckBox_NoKeepingCache.Name = "CheckBox_NoKeepingCache"
        Me.CheckBox_NoKeepingCache.Size = New System.Drawing.Size(189, 22)
        Me.CheckBox_NoKeepingCache.TabIndex = 4
        Me.CheckBox_NoKeepingCache.Text = "读完弹幕后立即删除缓存文件"
        Me.ToolTip_Default.SetToolTip(Me.CheckBox_NoKeepingCache, "在完成播放弹幕后立即删除缓存文件。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "注意：可能有至多 2 分钟的延迟时间。这些缓存将会遵循""自动清理 TTS 缓存""选项的设置进行管理。")
        Me.CheckBox_NoKeepingCache.UseVisualStyleBackColor = True
        '
        'Button_SetupWizard
        '
        Me.Button_SetupWizard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_SetupWizard.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_SetupWizard.Location = New System.Drawing.Point(579, 107)
        Me.Button_SetupWizard.Name = "Button_SetupWizard"
        Me.Button_SetupWizard.Size = New System.Drawing.Size(75, 23)
        Me.Button_SetupWizard.TabIndex = 23
        Me.Button_SetupWizard.Text = "设置向导"
        Me.ToolTip_Default.SetToolTip(Me.Button_SetupWizard, "运行设置向导，帮助您完成主要的插件配置。")
        Me.Button_SetupWizard.UseVisualStyleBackColor = True
        '
        'NumericUpDown_Volume
        '
        Me.NumericUpDown_Volume.Location = New System.Drawing.Point(193, 92)
        Me.NumericUpDown_Volume.Name = "NumericUpDown_Volume"
        Me.NumericUpDown_Volume.Size = New System.Drawing.Size(137, 23)
        Me.NumericUpDown_Volume.TabIndex = 17
        Me.ToolTip_Default.SetToolTip(Me.NumericUpDown_Volume, "调节 TTS 的相对音量大小。范围为 0（完全静音）~ 100（与系统音量一致）。")
        Me.NumericUpDown_Volume.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label_TTSVolume
        '
        Me.Label_TTSVolume.AutoSize = True
        Me.Label_TTSVolume.Location = New System.Drawing.Point(190, 72)
        Me.Label_TTSVolume.Name = "Label_TTSVolume"
        Me.Label_TTSVolume.Size = New System.Drawing.Size(57, 17)
        Me.Label_TTSVolume.TabIndex = 16
        Me.Label_TTSVolume.Text = "TTS 音量"
        '
        'Button_StatusReport
        '
        Me.Button_StatusReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_StatusReport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_StatusReport.Location = New System.Drawing.Point(579, 78)
        Me.Button_StatusReport.Name = "Button_StatusReport"
        Me.Button_StatusReport.Size = New System.Drawing.Size(75, 23)
        Me.Button_StatusReport.TabIndex = 22
        Me.Button_StatusReport.Text = "状态报告"
        Me.ToolTip_Default.SetToolTip(Me.Button_StatusReport, "以一定时间间隔报告直播间状态。")
        Me.Button_StatusReport.UseVisualStyleBackColor = True
        '
        'ComboBox_Engine
        '
        Me.ComboBox_Engine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Engine.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox_Engine.FormattingEnabled = True
        Me.ComboBox_Engine.Items.AddRange(New Object() {"百度翻译 API（伪", ".NET 框架自带引擎", "Google 娘"})
        Me.ComboBox_Engine.Location = New System.Drawing.Point(193, 44)
        Me.ComboBox_Engine.Name = "ComboBox_Engine"
        Me.ComboBox_Engine.Size = New System.Drawing.Size(137, 25)
        Me.ComboBox_Engine.TabIndex = 15
        Me.ToolTip_Default.SetToolTip(Me.ComboBox_Engine, "选择 TTS 引擎。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "首选引擎适合所有电脑，但稳定性和效率取决于网络性能。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "备用框架自带引擎不一定能正常工作。盗版系统失败概率较高。")
        '
        'Label_SpeechEngine
        '
        Me.Label_SpeechEngine.AutoSize = True
        Me.Label_SpeechEngine.Location = New System.Drawing.Point(190, 24)
        Me.Label_SpeechEngine.Name = "Label_SpeechEngine"
        Me.Label_SpeechEngine.Size = New System.Drawing.Size(57, 17)
        Me.Label_SpeechEngine.TabIndex = 14
        Me.Label_SpeechEngine.Text = "TTS 引擎"
        '
        'TextBox_CustomGiftContent
        '
        Me.TextBox_CustomGiftContent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_CustomGiftContent.Location = New System.Drawing.Point(6, 292)
        Me.TextBox_CustomGiftContent.Name = "TextBox_CustomGiftContent"
        Me.TextBox_CustomGiftContent.Size = New System.Drawing.Size(648, 23)
        Me.TextBox_CustomGiftContent.TabIndex = 11
        Me.ToolTip_Default.SetToolTip(Me.TextBox_CustomGiftContent, "在此自定义收到礼物后的读出内容。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "留空可关闭本项目读出功能。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "变量参考帮助:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://github.com/Elepover/Plugin-TT" &
        "SDanmaku/wiki")
        '
        'TextBox_CustomDMContent
        '
        Me.TextBox_CustomDMContent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_CustomDMContent.Location = New System.Drawing.Point(6, 246)
        Me.TextBox_CustomDMContent.Name = "TextBox_CustomDMContent"
        Me.TextBox_CustomDMContent.Size = New System.Drawing.Size(648, 23)
        Me.TextBox_CustomDMContent.TabIndex = 9
        Me.ToolTip_Default.SetToolTip(Me.TextBox_CustomDMContent, "在此自定义收到弹幕后的读出内容。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "留空可关闭本项目读出功能。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "变量参考帮助:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://github.com/Elepover/Plugin-TT" &
        "SDanmaku/wiki")
        '
        'Label_CustomGiftContent_Header
        '
        Me.Label_CustomGiftContent_Header.AutoSize = True
        Me.Label_CustomGiftContent_Header.Location = New System.Drawing.Point(6, 272)
        Me.Label_CustomGiftContent_Header.Name = "Label_CustomGiftContent_Header"
        Me.Label_CustomGiftContent_Header.Size = New System.Drawing.Size(116, 17)
        Me.Label_CustomGiftContent_Header.TabIndex = 10
        Me.Label_CustomGiftContent_Header.Text = "自定义礼物读出内容"
        '
        'Label_CustomDM_Header
        '
        Me.Label_CustomDM_Header.AutoSize = True
        Me.Label_CustomDM_Header.Location = New System.Drawing.Point(6, 226)
        Me.Label_CustomDM_Header.Name = "Label_CustomDM_Header"
        Me.Label_CustomDM_Header.Size = New System.Drawing.Size(116, 17)
        Me.Label_CustomDM_Header.TabIndex = 8
        Me.Label_CustomDM_Header.Text = "自定义弹幕读出内容"
        '
        'NumericUpDown_CoolDownValue
        '
        Me.NumericUpDown_CoolDownValue.Enabled = False
        Me.NumericUpDown_CoolDownValue.Location = New System.Drawing.Point(22, 199)
        Me.NumericUpDown_CoolDownValue.Maximum = New Decimal(New Integer() {600000, 0, 0, 0})
        Me.NumericUpDown_CoolDownValue.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_CoolDownValue.Name = "NumericUpDown_CoolDownValue"
        Me.NumericUpDown_CoolDownValue.Size = New System.Drawing.Size(145, 23)
        Me.NumericUpDown_CoolDownValue.TabIndex = 7
        Me.ToolTip_Default.SetToolTip(Me.NumericUpDown_CoolDownValue, "设置 TTS 冷却值（以毫秒为单位）。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1s = 1000ms.")
        Me.NumericUpDown_CoolDownValue.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label_Value_Prefix
        '
        Me.Label_Value_Prefix.AutoSize = True
        Me.Label_Value_Prefix.Location = New System.Drawing.Point(19, 179)
        Me.Label_Value_Prefix.Name = "Label_Value_Prefix"
        Me.Label_Value_Prefix.Size = New System.Drawing.Size(98, 17)
        Me.Label_Value_Prefix.TabIndex = 6
        Me.Label_Value_Prefix.Text = "TTS 冷却值 (ms)"
        '
        'CheckBox_TTSCoolDown
        '
        Me.CheckBox_TTSCoolDown.AutoSize = True
        Me.CheckBox_TTSCoolDown.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_TTSCoolDown.Location = New System.Drawing.Point(6, 161)
        Me.CheckBox_TTSCoolDown.Name = "CheckBox_TTSCoolDown"
        Me.CheckBox_TTSCoolDown.Size = New System.Drawing.Size(82, 22)
        Me.CheckBox_TTSCoolDown.TabIndex = 5
        Me.CheckBox_TTSCoolDown.Text = "TTS 冷却"
        Me.ToolTip_Default.SetToolTip(Me.CheckBox_TTSCoolDown, "在读出一条弹幕的一段时间内不再读出其他弹幕。")
        Me.CheckBox_TTSCoolDown.UseVisualStyleBackColor = True
        '
        'CheckBox_NoCache
        '
        Me.CheckBox_NoCache.AutoSize = True
        Me.CheckBox_NoCache.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_NoCache.Location = New System.Drawing.Point(6, 106)
        Me.CheckBox_NoCache.Name = "CheckBox_NoCache"
        Me.CheckBox_NoCache.Size = New System.Drawing.Size(134, 22)
        Me.CheckBox_NoCache.TabIndex = 3
        Me.CheckBox_NoCache.Text = "自动清理 TTS 缓存"
        Me.ToolTip_Default.SetToolTip(Me.CheckBox_NoCache, "在插件被启用时自动清理 TTS 缓存。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "注意：启用这个选项可能会延长插件启动时间并导致弹幕姬假死。")
        Me.CheckBox_NoCache.UseVisualStyleBackColor = True
        '
        'Button_Load
        '
        Me.Button_Load.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Load.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Load.Location = New System.Drawing.Point(579, 49)
        Me.Button_Load.Name = "Button_Load"
        Me.Button_Load.Size = New System.Drawing.Size(75, 23)
        Me.Button_Load.TabIndex = 21
        Me.Button_Load.Text = "重新读取"
        Me.ToolTip_Default.SetToolTip(Me.Button_Load, "重新读取已经保存的设置。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "这将丢弃您当前的所有更改。")
        Me.Button_Load.UseVisualStyleBackColor = True
        '
        'Button_Apply
        '
        Me.Button_Apply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Apply.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Apply.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Apply.Location = New System.Drawing.Point(579, 21)
        Me.Button_Apply.Name = "Button_Apply"
        Me.Button_Apply.Size = New System.Drawing.Size(75, 23)
        Me.Button_Apply.TabIndex = 20
        Me.Button_Apply.Text = "应用"
        Me.Button_Apply.UseVisualStyleBackColor = True
        '
        'CheckBox_TTSGifts
        '
        Me.CheckBox_TTSGifts.AutoSize = True
        Me.CheckBox_TTSGifts.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_TTSGifts.Location = New System.Drawing.Point(6, 78)
        Me.CheckBox_TTSGifts.Name = "CheckBox_TTSGifts"
        Me.CheckBox_TTSGifts.Size = New System.Drawing.Size(117, 22)
        Me.CheckBox_TTSGifts.TabIndex = 2
        Me.CheckBox_TTSGifts.Text = "读出收到的礼物"
        Me.ToolTip_Default.SetToolTip(Me.CheckBox_TTSGifts, "读出所收到的礼物，包括发送者名称。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "（在 B 站，雷锋什么的，不存在的（跑")
        Me.CheckBox_TTSGifts.UseVisualStyleBackColor = True
        '
        'CheckBox_TTSSender
        '
        Me.CheckBox_TTSSender.AutoSize = True
        Me.CheckBox_TTSSender.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_TTSSender.Location = New System.Drawing.Point(6, 50)
        Me.CheckBox_TTSSender.Name = "CheckBox_TTSSender"
        Me.CheckBox_TTSSender.Size = New System.Drawing.Size(117, 22)
        Me.CheckBox_TTSSender.TabIndex = 1
        Me.CheckBox_TTSSender.Text = "读出弹幕发送者"
        Me.ToolTip_Default.SetToolTip(Me.CheckBox_TTSSender, "读出弹幕发送者。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "当然你觉得不想看到某个人的话也可以关掉（跑")
        Me.CheckBox_TTSSender.UseVisualStyleBackColor = True
        '
        'CheckBox_TTSDebug
        '
        Me.CheckBox_TTSDebug.AutoSize = True
        Me.CheckBox_TTSDebug.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_TTSDebug.Location = New System.Drawing.Point(6, 22)
        Me.CheckBox_TTSDebug.Name = "CheckBox_TTSDebug"
        Me.CheckBox_TTSDebug.Size = New System.Drawing.Size(105, 22)
        Me.CheckBox_TTSDebug.TabIndex = 0
        Me.CheckBox_TTSDebug.Text = "启用调试模式"
        Me.ToolTip_Default.SetToolTip(Me.CheckBox_TTSDebug, "这个功能也叫唠叨模式。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "它会把弹幕姬输出框从 安静的御姐 变成 啰嗦的老太婆。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "没有胆量的用户或者萌新，请勿尝试。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "（逃")
        Me.CheckBox_TTSDebug.UseVisualStyleBackColor = True
        '
        'GroupBox_Statistics
        '
        Me.GroupBox_Statistics.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Statistics.Controls.Add(Me.TextBox_Stats)
        Me.GroupBox_Statistics.Location = New System.Drawing.Point(12, 376)
        Me.GroupBox_Statistics.Name = "GroupBox_Statistics"
        Me.GroupBox_Statistics.Size = New System.Drawing.Size(660, 110)
        Me.GroupBox_Statistics.TabIndex = 1
        Me.GroupBox_Statistics.TabStop = False
        Me.GroupBox_Statistics.Text = "统计数据"
        '
        'TextBox_Stats
        '
        Me.TextBox_Stats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Stats.Location = New System.Drawing.Point(11, 22)
        Me.TextBox_Stats.Multiline = True
        Me.TextBox_Stats.Name = "TextBox_Stats"
        Me.TextBox_Stats.ReadOnly = True
        Me.TextBox_Stats.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_Stats.Size = New System.Drawing.Size(643, 75)
        Me.TextBox_Stats.TabIndex = 0
        Me.ToolTip_Default.SetToolTip(Me.TextBox_Stats, "截至插件本次启动运行到目前的统计数据。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "当您启动插件时，数据将被清空。")
        '
        'GroupBox_TempMgr
        '
        Me.GroupBox_TempMgr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_TempMgr.Controls.Add(Me.Button_DeleteAll)
        Me.GroupBox_TempMgr.Controls.Add(Me.TextBox_Files)
        Me.GroupBox_TempMgr.Location = New System.Drawing.Point(12, 492)
        Me.GroupBox_TempMgr.Name = "GroupBox_TempMgr"
        Me.GroupBox_TempMgr.Size = New System.Drawing.Size(660, 99)
        Me.GroupBox_TempMgr.TabIndex = 2
        Me.GroupBox_TempMgr.TabStop = False
        Me.GroupBox_TempMgr.Text = "管理下载的 TTS 文件缓存"
        '
        'Button_DeleteAll
        '
        Me.Button_DeleteAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_DeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_DeleteAll.Location = New System.Drawing.Point(595, 22)
        Me.Button_DeleteAll.Name = "Button_DeleteAll"
        Me.Button_DeleteAll.Size = New System.Drawing.Size(59, 64)
        Me.Button_DeleteAll.TabIndex = 1
        Me.Button_DeleteAll.Text = "全部" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "删除"
        Me.ToolTip_Default.SetToolTip(Me.Button_DeleteAll, "手动删除缓存目录中的所有 TTS 缓存。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "您也可以启动【自动删除 TTS 缓存】选项。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "当前会话中产生的 TTS 缓存由于文件占用无法删除，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "可在下次启" &
        "动时手动清除。")
        Me.Button_DeleteAll.UseVisualStyleBackColor = True
        '
        'TextBox_Files
        '
        Me.TextBox_Files.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Files.Location = New System.Drawing.Point(11, 22)
        Me.TextBox_Files.Multiline = True
        Me.TextBox_Files.Name = "TextBox_Files"
        Me.TextBox_Files.ReadOnly = True
        Me.TextBox_Files.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_Files.Size = New System.Drawing.Size(578, 64)
        Me.TextBox_Files.TabIndex = 0
        '
        'Button_Close
        '
        Me.Button_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Close.Location = New System.Drawing.Point(597, 597)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(75, 23)
        Me.Button_Close.TabIndex = 8
        Me.Button_Close.Text = "关闭"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Button_Reload
        '
        Me.Button_Reload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_Reload.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Reload.Location = New System.Drawing.Point(12, 597)
        Me.Button_Reload.Name = "Button_Reload"
        Me.Button_Reload.Size = New System.Drawing.Size(75, 23)
        Me.Button_Reload.TabIndex = 3
        Me.Button_Reload.Text = "重载"
        Me.ToolTip_Default.SetToolTip(Me.Button_Reload, "重新载入以下配置：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-> 设置选项" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-> 缓存文件")
        Me.Button_Reload.UseVisualStyleBackColor = True
        '
        'LinkLabel_About
        '
        Me.LinkLabel_About.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_About.AutoSize = True
        Me.LinkLabel_About.Location = New System.Drawing.Point(93, 600)
        Me.LinkLabel_About.Name = "LinkLabel_About"
        Me.LinkLabel_About.Size = New System.Drawing.Size(112, 17)
        Me.LinkLabel_About.TabIndex = 4
        Me.LinkLabel_About.TabStop = True
        Me.LinkLabel_About.Text = "关于 TTSDanmaku"
        Me.ToolTip_Default.SetToolTip(Me.LinkLabel_About, "在弹幕姬网站上查看插件信息。")
        '
        'ToolTip_Default
        '
        Me.ToolTip_Default.BackColor = System.Drawing.Color.White
        '
        'LinkLabel_Suggestions
        '
        Me.LinkLabel_Suggestions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_Suggestions.AutoSize = True
        Me.LinkLabel_Suggestions.Location = New System.Drawing.Point(511, 600)
        Me.LinkLabel_Suggestions.Name = "LinkLabel_Suggestions"
        Me.LinkLabel_Suggestions.Size = New System.Drawing.Size(80, 17)
        Me.LinkLabel_Suggestions.TabIndex = 7
        Me.LinkLabel_Suggestions.TabStop = True
        Me.LinkLabel_Suggestions.Text = "给我一点建议"
        Me.ToolTip_Default.SetToolTip(Me.LinkLabel_Suggestions, "前往作者的留言板。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "我会尽快回复相关建议，但不一定准时准点，感谢理解。")
        '
        'LinkLabel_FAQ
        '
        Me.LinkLabel_FAQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_FAQ.AutoSize = True
        Me.LinkLabel_FAQ.Location = New System.Drawing.Point(449, 600)
        Me.LinkLabel_FAQ.Name = "LinkLabel_FAQ"
        Me.LinkLabel_FAQ.Size = New System.Drawing.Size(56, 17)
        Me.LinkLabel_FAQ.TabIndex = 6
        Me.LinkLabel_FAQ.TabStop = True
        Me.LinkLabel_FAQ.Text = "常见问题"
        Me.ToolTip_Default.SetToolTip(Me.LinkLabel_FAQ, "查看常遇到的问题以及解决方案。")
        '
        'Label_ThanksViaMyHeart
        '
        Me.Label_ThanksViaMyHeart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_ThanksViaMyHeart.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label_ThanksViaMyHeart.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Label_ThanksViaMyHeart.Location = New System.Drawing.Point(211, 597)
        Me.Label_ThanksViaMyHeart.Name = "Label_ThanksViaMyHeart"
        Me.Label_ThanksViaMyHeart.Size = New System.Drawing.Size(232, 23)
        Me.Label_ThanksViaMyHeart.TabIndex = 5
        Me.Label_ThanksViaMyHeart.Text = "真诚地感谢您使用本插件。"
        Me.Label_ThanksViaMyHeart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip_Default.SetToolTip(Me.Label_ThanksViaMyHeart, "真诚地在此感谢您在安装使用本插件上所花费的分分秒秒。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """相聚是缘，相逢是歌""，您的使用是对我最大的鼓舞。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "如果有任何使用问题，请参见右侧常见问题。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "如没" &
        "有列出，敬请随时与我联系。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "若不重要，请您选择 在""给我一些建议""处留下您的意见和建议。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copyright (C) 2017 Elepover." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" &
        "his is an open-source(MIT) software.")
        '
        'Button_CheckUpdates
        '
        Me.Button_CheckUpdates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_CheckUpdates.Location = New System.Drawing.Point(579, 136)
        Me.Button_CheckUpdates.Name = "Button_CheckUpdates"
        Me.Button_CheckUpdates.Size = New System.Drawing.Size(75, 23)
        Me.Button_CheckUpdates.TabIndex = 24
        Me.Button_CheckUpdates.Text = "检查更新"
        Me.ToolTip_Default.SetToolTip(Me.Button_CheckUpdates, "检查插件更新。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "按下 Shift 再点击按钮可检查测试版更新。")
        Me.Button_CheckUpdates.UseVisualStyleBackColor = True
        '
        'TTSDanmakuMgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Button_Close
        Me.ClientSize = New System.Drawing.Size(684, 652)
        Me.Controls.Add(Me.Label_ThanksViaMyHeart)
        Me.Controls.Add(Me.LinkLabel_FAQ)
        Me.Controls.Add(Me.LinkLabel_Suggestions)
        Me.Controls.Add(Me.LinkLabel_About)
        Me.Controls.Add(Me.StatusStrip_Main)
        Me.Controls.Add(Me.GroupBox_TTSOptions)
        Me.Controls.Add(Me.GroupBox_Statistics)
        Me.Controls.Add(Me.GroupBox_TempMgr)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Button_Reload)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(700, 690)
        Me.Name = "TTSDanmakuMgmt"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TTSDanmaku - Admin"
        Me.StatusStrip_Main.ResumeLayout(False)
        Me.StatusStrip_Main.PerformLayout()
        Me.GroupBox_TTSOptions.ResumeLayout(False)
        Me.GroupBox_TTSOptions.PerformLayout()
        CType(Me.NumericUpDown_RetryCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Volume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_CoolDownValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Statistics.ResumeLayout(False)
        Me.GroupBox_Statistics.PerformLayout()
        Me.GroupBox_TempMgr.ResumeLayout(False)
        Me.GroupBox_TempMgr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip_Main As Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel_Default As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox_TTSOptions As Windows.Forms.GroupBox
    Friend WithEvents Button_Load As Windows.Forms.Button
    Friend WithEvents Button_Apply As Windows.Forms.Button
    Friend WithEvents CheckBox_TTSGifts As Windows.Forms.CheckBox
    Friend WithEvents CheckBox_TTSSender As Windows.Forms.CheckBox
    Friend WithEvents CheckBox_TTSDebug As Windows.Forms.CheckBox
    Friend WithEvents GroupBox_Statistics As Windows.Forms.GroupBox
    Friend WithEvents TextBox_Stats As Windows.Forms.TextBox
    Friend WithEvents GroupBox_TempMgr As Windows.Forms.GroupBox
    Friend WithEvents Button_DeleteAll As Windows.Forms.Button
    Friend WithEvents TextBox_Files As Windows.Forms.TextBox
    Friend WithEvents Button_Close As Windows.Forms.Button
    Friend WithEvents Button_Reload As Windows.Forms.Button
    Friend WithEvents CheckBox_NoCache As Windows.Forms.CheckBox
    Friend WithEvents LinkLabel_About As Windows.Forms.LinkLabel
    Friend WithEvents CheckBox_TTSCoolDown As Windows.Forms.CheckBox
    Friend WithEvents Label_Value_Prefix As Windows.Forms.Label
    Friend WithEvents NumericUpDown_CoolDownValue As Windows.Forms.NumericUpDown
    Friend WithEvents ToolTip_Default As Windows.Forms.ToolTip
    Friend WithEvents LinkLabel_Suggestions As Windows.Forms.LinkLabel
    Friend WithEvents Label_CustomDM_Header As Windows.Forms.Label
    Friend WithEvents TextBox_CustomGiftContent As Windows.Forms.TextBox
    Friend WithEvents TextBox_CustomDMContent As Windows.Forms.TextBox
    Friend WithEvents Label_CustomGiftContent_Header As Windows.Forms.Label
    Friend WithEvents LinkLabel_FAQ As Windows.Forms.LinkLabel
    Friend WithEvents Label_SpeechEngine As Windows.Forms.Label
    Friend WithEvents ComboBox_Engine As Windows.Forms.ComboBox
    Friend WithEvents Button_StatusReport As Windows.Forms.Button
    Friend WithEvents Label_ThanksViaMyHeart As Windows.Forms.Label
    Friend WithEvents Label_TTSVolume As Windows.Forms.Label
    Friend WithEvents NumericUpDown_Volume As Windows.Forms.NumericUpDown
    Friend WithEvents Button_SetupWizard As Windows.Forms.Button
    Friend WithEvents CheckBox_NoKeepingCache As Windows.Forms.CheckBox
    Friend WithEvents Label_CustomConnected As Windows.Forms.Label
    Friend WithEvents TextBox_CustomConnected As Windows.Forms.TextBox
    Friend WithEvents Label_RetryCount As Windows.Forms.Label
    Friend WithEvents NumericUpDown_RetryCount As Windows.Forms.NumericUpDown
    Friend WithEvents Button_CheckUpdates As Windows.Forms.Button
End Class
