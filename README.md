

**`本工具不再更新，请移步` https://github.com/w600/wm_tools `进行替换。`**

w600_download_tool 是一个基于 xmodem 通信协议的串口工具，可以实现 w600 的固件烧录，目前仅支持 windows 平台。

运行和编译需依赖 .Net 4.0 平台https://www.microsoft.com/en-us/download/details.aspx?id=17718

# 编译说明

使用 SharpDevelop 4.4 编译，也可使用 Visual Studio 2010 以上版本编译，

# 使用说明

* 参数：

​	w600_download_tool.exe  \<filename> \<port> \<baud>

​	波特率范围： 115200, 460800, 921600, 1000000, 2000000


* 示例：

​	w600_download_tool.exe w600_sec.img COM5 2000000

# 其它

有任何疑问或问题反馈，可联系 support@thingsturn.com