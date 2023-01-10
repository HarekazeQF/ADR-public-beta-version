using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Formats.Tar;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;






namespace ADR5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Process process;
        private bool running = false;


        //python检查







        public MainWindow()
        {

            InitializeComponent();






           

            
       














            string filePath11 = Directory.GetCurrentDirectory() + @"\1sta.txt";
           

            if (File.Exists(filePath11))
            {
                Console.WriteLine("1");
                安装页面.Visibility = Visibility.Hidden;
                直接在当前目录使用.Visibility = Visibility.Hidden;
                为PC上的所有版本安装并在桌面显示快捷方式.Visibility = Visibility.Hidden;
            }
            else
            {
                File.Create(filePath11);
                Console.WriteLine("1sta.txt has been created in the current directory.");
            }


            // DREAMBOOTH检测
            string currentDirectory9 = Directory.GetCurrentDirectory();
            // 拼接 extensions 文件夹路径
            string extensionsDirectory = System.IO.Path.Combine(currentDirectory9, "extensions");
            // 判断 extensions 文件夹是否存在
            if (Directory.Exists(extensionsDirectory))
            {
                // 拼接 sd_dreambooth_extension 文件夹路径
                string extensionDirectory = System.IO.Path.Combine(extensionsDirectory, "sd_dreambooth_extension");
                // 判断 sd_dreambooth_extension 文件夹是否存在
                if (Directory.Exists(extensionDirectory))
                {
                    Dreanmbooth.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    Dreambooth信息显示.Text = ("Dreambooth已安装");
                }
                else
                {
                    Dreanmbooth.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    Dreambooth信息显示.Text = ("Dreambooth未安装");

                }
            }
            // DREAMBOOTH检测

            // 判断 extensions 文件夹是否存在
            if (Directory.Exists(extensionsDirectory))
            {
                // 拼接 sd_dreambooth_extension 文件夹路径
                string extensionDirectory = System.IO.Path.Combine(extensionsDirectory, "stable-diffusion-webui-embedding-editor");
                // 判断 sd_dreambooth_extension 文件夹是否存在
                if (Directory.Exists(extensionDirectory))
                {
                    嵌入编辑器.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    嵌入编辑器状态显示.Text = ("嵌入编辑器已安装");

                }
                else
                {
                    嵌入编辑器.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    嵌入编辑器状态显示.Text = ("嵌入编辑器未安装");


                }
            }
            // 判断 extensions 文件夹是否存在
            if (Directory.Exists(extensionsDirectory))
            {
                // 拼接 sd_dreambooth_extension 文件夹路径
                string extensionDirectory = System.IO.Path.Combine(extensionsDirectory, "stable-diffusion-webui-sonar");
                // 判断 sd_dreambooth_extension 文件夹是否存在
                if (Directory.Exists(extensionDirectory))
                {
                    声纳.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    声纳状态显示.Text = ("声呐已安装");
                }
                else
                {
                    声纳.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    声纳状态显示.Text = ("声呐未安装");


                }
            }
            if (Directory.Exists(extensionsDirectory))
            {
                // 拼接 sd_dreambooth_extension 文件夹路径
                string extensionDirectory = System.IO.Path.Combine(extensionsDirectory, "stable-diffusion-webui-images-browser");
                // 判断 sd_dreambooth_extension 文件夹是否存在
                if (Directory.Exists(extensionDirectory))
                {
                    历史图库.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    历史图库状态显示.Text = ("图像浏览器已安装");
                }
                else
                {
                    历史图库.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    历史图库状态显示.Text = ("图像浏览器未安装");


                }
            }
            if (Directory.Exists(extensionsDirectory))
            {
                // 拼接 sd_dreambooth_extension 文件夹路径
                string extensionDirectory = System.IO.Path.Combine(extensionsDirectory, "booru2prompt");
                // 判断 sd_dreambooth_extension 文件夹是否存在
                if (Directory.Exists(extensionDirectory))
                {
                    booru2prompt.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    booru2prompt模式显示.Text = ("booru2反推已安装");
                }
                else
                {
                    booru2prompt.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    booru2prompt模式显示.Text = ("booru2反推未安装");


                }
            }
            if (Directory.Exists(extensionsDirectory))
            {
                // 拼接 sd_dreambooth_extension 文件夹路径
                string extensionDirectory = System.IO.Path.Combine(extensionsDirectory, "stable-diffusion-webui-embedding-editor");
                // 判断 sd_dreambooth_extension 文件夹是否存在
                if (Directory.Exists(extensionDirectory))
                {
                    深度图.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    深度图模式信息.Text = ("深度图已安装");
                }
                else
                {
                    深度图.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    深度图模式信息.Text = ("深度图未安装");


                }
            }

































            // 检查python
            const string pythonKey = @"SOFTWARE\Python\PythonCore";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(pythonKey))
            {
                if (key == null)
                {
                    //Console.WriteLine("Python is not installed on this system.");
                    Python信息.Text = ("你的PC上没有安装Python\n安装后请重启启动器 安装->");
                    Python安装按钮.Visibility = Visibility.Visible;
                    return;
                }


                // Get the latest installed version of Python
                string[] subKeyNames = key.GetSubKeyNames();
                string latestVersion = subKeyNames[subKeyNames.Length - 1];
                //Console.WriteLine($"Python {latestVersion} is installed on this system.");
                Python信息.Text = ($"当前Python版本为{latestVersion}");
                Python安装按钮.Visibility = Visibility.Hidden;

            }

            string gitPath = @"C:\Program Files\Git\bin\git.exe";
            if (File.Exists(gitPath))
            {
                //Console.WriteLine("Git is installed on this system.");
                Git信息.Text = ($"Git已安装，位置是\n{gitPath}");
                Git安装按钮.Visibility = Visibility.Hidden;
            }
            else
            {
                //Console.WriteLine("Git is not installed on this system.");
                Git信息.Text = ("请点击右侧按钮安装GIT\n安装后请重启启动器");

            }

            //检查系统中是否安装了CUDA环境
            // 创建WMI查询对象
            //{ var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            //// 遍历查询结果
            //foreach (var obj in searcher.Get())
            //{
            //    // 获取视频控制器名称
            //    var name = obj["Name"];
            //    // 如果名称包含"CUDA"字符串，则表示有CUDA环境
            //    if (name.ToString().Contains("CUDA"))
            //    {
            //        //Console.WriteLine("CUDA environment detected.");
            //        return;
            //    }
            //}
            ////Console.WriteLine("CUDA environment not detected.");
            //}
            bool cudaFound = false;


            // Connect to the local machine

            //SD版本检查
            try
            {
                string url = "https://api.github.com/repos/AUTOMATIC1111/stable-diffusion-webui/commits"; // API地址
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url); // 创建请求
                request.Method = "GET"; // 请求方式为GET
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3"; // 设置User-Agent
                request.ContentType = "application/json"; // 设置Content-Type


                HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // 获取响应
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8); // 读取响应流
                string result = reader.ReadToEnd(); // 读取完整响应

                // 解析最新提交时间
                int index = result.IndexOf("\"commit\": {"); // 先找到"commit": {的位置
                string commitInfo = result.Substring(index); // 截取包含最新提交信息的字符串
                index = commitInfo.IndexOf("\"date\": \""); // 再找到"date": "的位置
                string date = commitInfo.Substring(index + 9, 19); // 截取时间字符串
                //Console.WriteLine("最新提交时间: " + date);
                SD信息.Text = ("最新版的StableDiffusion为：\n" + date);
                网速接口名称显示.Text = ("网络已连接");

            }
            catch (WebException)
            {
                //Console.WriteLine("无法连接到以上地址，请使用Steam++为Github加速");
                SD信息.Text = "由于网络问题导致无法检查\n到最新版,请使用\nSteam++为Github加速";
                网速接口名称显示.Text = ("网络未连接");
            }


            //本地版本检查
            // 获取当前程序的目录
            string currentDirectory1 = Directory.GetCurrentDirectory();


            // 将文件路径拼接起来
            string filePath3 = System.IO.Path.Combine(currentDirectory1, "webui.py");

            // 判断文件是否存在
            if (!File.Exists(filePath3))
            {
                //Console.WriteLine("文件不存在！");
                本地版本信息.Text = ("没有发现你安装了Stable\n diffusion Webui\n点击上方按钮下载一个版本哦");
                启动按钮.Content = ("无可用版本/关闭");
                启动按钮.Background = new SolidColorBrush(Colors.Red);
                return;
            }

            // 获取文件信息
            FileInfo fileInfo = new FileInfo(filePath3);
            // 获取文件的修改时间
            DateTime lastModifiedTime = File.GetLastWriteTime(filePath3);

            // 输出文件创建时间
            //Console.WriteLine("webui.py创建时间：" + fileInfo.CreationTime);
            本地版本信息.Text = ("当前版本安装时间\n" + lastModifiedTime + "\n最新版不一定稳定哦）");



            //命令行检查
            //string currentDirectory = Directory.GetCurrentDirectory();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
























            string filePath = System.IO.Path.Combine(currentDirectory, "webui-user.bat");
            string outputsDirectory = currentDirectory + "outputs";









            //检查danbooru
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                if (fileContent.Contains("--deepdanbooru"))
                {
                    danbooru状态显示.Text = ("Deepdanbooru已开启");
                    danbooru加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    //Console.WriteLine("--deepdanbooru found");
                }
                else
                {
                    danbooru状态显示.Text = ("Deepdanbooru已关闭");
                    danbooru加载按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    //Console.WriteLine("--deepdanbooru not found");
                }
            }
            //检查网络

            //检查网络是否连接
            //bool isConnected = NetworkInterface.GetIsNetworkAvailable();
            //if (isConnected)
            //{
            //    //Console.WriteLine("网络已连接");
            //    //获取网络接口信息
            //    NetworkInterface[] nis = NetworkInterface.GetAllNetworkInterfaces();
            //    foreach (NetworkInterface ni in nis)
            //    {
            //        //如果当前网络接口是连接的，则获取其网速信息
            //        if (ni.OperationalStatus == OperationalStatus.Up)
            //        {
            //            网速接口名称显示.Text=("网络接口名称：" + ni.Name);
            //            网速上行速率显示.Text=("上行网速：" + ni.Speed / 1024 / 1024 + "Mb/s");
            //            网速下行速率显示.Text=("下行网速：" + ni.Speed / 1024 / 1024 + "Mb/s");
            //        }
            //    }
            //}
            //else
            //{
            //    分享到公共网络.Text=("网络未连接");
            //}
            //if (NetworkInterface.GetIsNetworkAvailable())
            //{
            //    Console.WriteLine("Network is available");
            //    //获取所有网络接口
            //    NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            //    //遍历所有网络接口
            //    foreach (NetworkInterface ni in interfaces)
            //    {
            //        //输出网络接口名称和状态
            //        Console.WriteLine("Interface: {0}, Status: {1}", ni.Name, ni.OperationalStatus);
            //        //获取实时上行/下行网络数据
            //        IPv4InterfaceStatistics statistics = ni.GetIPv4Statistics();
            //        Console.WriteLine("Upload Speed: {0} bps, Download Speed: {1} bps", statistics.BytesSentPerSecond, statistics.BytesReceivedPerSecond);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Network is not available");
            //}

            //获取本地网络接口信息
            //NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            //foreach (NetworkInterface ni in interfaces)
            //{
            ////检查网络是否连接
            //if  (NetworkInterface.GetIsNetworkAvailable())
            //{



            //                网速接口名称显示.Text = ("网络已连接");



            //        ////Console.WriteLine
            //        ////获取IPv4统计信息
            //        //IPv4InterfaceStatistics stats = ni.GetIPv4Statistics();
            //        ////获取实时上行网络数据
            //        //long bytesSent = stats.BytesSent;
            //        ////网速上行速率显示.Text=("实时上行网络数据：" + bytesSent + "字节");
            //        ////获取实时下行网络数据
            //        //long bytesReceived = stats.BytesReceived;
            //        //网速下行速率显示.Text=("实时下行网络数据：" + bytesReceived + "字节");
            //    }
            //    else
            //    {
            //        网速接口名称显示.Text=("网络未连接");
            //    }





            //检查颜色模式
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                if (fileContent.Contains("--autolaunch"))
                {
                    浏览器自启动信息显示.Text = ("浏览器自启动已开启");
                    浏览器自动加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    //Console.WriteLine("--deepdanbooru found");
                }
                else
                {
                    浏览器自启动信息显示.Text = ("浏览器自启动已关闭");
                    浏览器自动加载按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    //Console.WriteLine("--deepdanbooru not found");
                }
            }
            //低显存模式按钮
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                if (fileContent.Contains("--lowvram"))
                {
                    低显存模式显示.Text = ("低显存模式已开启");
                    低显存加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    //Console.WriteLine("--deepdanbooru found");
                }
                else
                {
                    低显存模式显示.Text = ("低显存模式已关闭");
                    低显存加载按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    //Console.WriteLine("--deepdanbooru not found");
                }
            }
            //运算精度模式
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                if (fileContent.Contains("--no-half"))
                {
                    计算精度状态显示.Text = ("全精度运算已开启");
                    半精度加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    //Console.WriteLine("--deepdanbooru found");
                }
                else
                {
                    计算精度状态显示.Text = ("混合精度运算开启");
                    半精度加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 78, 85, 255));
                    //Console.WriteLine("--deepdanbooru not found");
                }
            }
            //检查XFormer
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                if (fileContent.Contains("--xformers"))
                {
                    Xformer状态显示.Text = ("Xformer已开启");
                    Xformer加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    //Console.WriteLine("--deepdanbooru found");
                }
                else
                {
                    Xformer状态显示.Text = ("Xformer已关闭");
                    Xformer加载按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    //Console.WriteLine("--deepdanbooru not found");
                }
            }
            //检查公网分享
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                if (fileContent.Contains("--share"))
                {
                    分享到公共网络.Text = ("公网分享已开启");
                    公网分享按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    //Console.WriteLine("--deepdanbooru found");
                }
                else
                {
                    分享到公共网络.Text = ("公网分享已关闭");
                    公网分享按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    //Console.WriteLine("--deepdanbooru not found");
                }
            }

            //检擦内存模式相关信息

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                if (fileContent.Contains("--lowram"))
                {
                    内存模式信息.Text = (" 低内存模式已开启");
                    低内存模式加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    //Console.WriteLine("--deepdanbooru found");
                }
                else
                {
                    内存模式信息.Text = (" 低内存模式已关闭");
                    低内存模式加载按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    //Console.WriteLine("--deepdanbooru not found");
                }
            }



            //相册数据显示代码


            {


                {
                    if (!Directory.Exists(outputsDirectory))
                    {
                        // 如果不存在，将"未找到相册"赋值给A1
                        相册数据显示.Content = "未找到相册";


                    }
                    else//相册计数功能
                    {
                        int imageFileCount = 0;
                        // 遍历outputs文件夹及其子文件夹
                        foreach (string directory in Directory.GetDirectories(outputsDirectory, "*", System.IO.SearchOption.AllDirectories))
                        {
                            // 遍历当前目录下的所有文件
                            foreach (string file in Directory.GetFiles(directory))
                            {
                                // 获取文件后缀名
                                string extension = System.IO.Path.GetExtension(file);
                                // 判断是否为图片文件
                                if (extension == ".png" || extension == ".jpg" || extension == ".jpeg" || extension == ".gif")
                                {
                                    // 如果是图片文件，图片文件数量加1
                                    imageFileCount++;
                                }
                            }
                        }
                        // 将图片文件数量写入变量AI
                        int AI = imageFileCount;
                        相册数据显示.Content = ("图片文件数量：" + AI);
                    }
                }
                // Sleep for 5 seconds before checking again




            }




        }
        //AI绘画相册按钮

        //按钮操作逻辑

        private void 启动按钮_Click(object sender, RoutedEventArgs e)


        {


            // 如果进程没有启动，就启动它
            if (process == null || process.HasExited)
            {

                启动按钮.Content = "停止运行";
                启动按钮.Background = new SolidColorBrush(Colors.Red);



                //                Process process = new Process();
                //                process.StartInfo.FileName = "webui-user.bat";
                //                process.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                //                process.Start();
                //                //process.WaitForExit();
                //                // 获取输出
                //                string output = process.StandardOutput.ReadToEnd();
                //                //Console.WriteLine(output);

                //                //设置流读取的编码方式
                ////process.StandardOutput.ReadLine().Encoding = Encoding.UTF8;
                //                //读取命令行的输出
                //                string line;
                //                while ((line = process.StandardOutput.ReadLine()) != null)
                //                {
                //                    //查找文字"Running on public URL:"
                //                    if (line.Contains("Running on public URL:"))
                //                    {
                //                        //获取之后同一行的内容
                //                        string url = line.Substring(line.IndexOf("Running on public URL:") + "Running on public URL:".Length);
                //                        //Console.WriteLine(url);
                //                        公网链接显示.Text = " 你现在可以用手机 / 其他设备打开这个链接" + url;
                //                        break;
                //                    }



                // 创建一个新的进程
                process = new Process();

                // 设置要启动的文件的路径
                string filePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "webui-user.bat");
                process.StartInfo.FileName = filePath;

                // 启动进程
                process.Start();
            }

            else
            {
                启动按钮.Content = "一键启动";
                启动按钮.Background = new SolidColorBrush(Color.FromArgb(255, 255, 200, 10));
                // 如果进程已经启动，就关闭它
                process.CloseMainWindow();

            }


            //// 获取当前进程（即CMD命令行）
            //Process cmdProcess = Process.GetCurrentProcess();
            //// 获取进程的输出流
            //StreamReader reader = cmdProcess.StandardOutput;
            //// 创建一个字符串变量来存储输出流中的文本
            //string output = reader.ReadToEnd();


            //// 定义一个布尔变量表示是否找到了"Running on public URL:"
            //bool found = false;
            //// 循环处理每一行输出
            //foreach (string line in output.Split(new string[] { "\r\n" }, StringSplitOptions.None))
            //{
            //    // 如果找到了"Running on public URL:"
            //    if (found)
            //    {
            //        // 输出同一行的内容
            //        //Console.WriteLine(line);
            //        公网链接显示.Text = " 你现在可以用手机 / 其他设备打开这个链接"+line;
            //        // 退出循环
            //        break;
            //    }
            //    // 如果当前行包含"Running on public URL:"
            //    if (line.Contains("Running on public URL:"))
            //    {
            //        // 设置布尔变量为true
            //        //found = true;

            //    }
            //}





            //if (process == null || process.HasExited)
            //{
            //    // 如果进程未运行或已经停止，则启动进程
            //    process = Process.Start("webui-user.bat");
            //    
            //}
            //else
            //{
            //    // 如果进程正在运行，则停止进程
            //    process.Kill();
            //    process.WaitForExit();
            //    process = null;

            //}
            //if (!running)
            //{
            //    // Start the process
            //    process = Process.Start("webui-user.bat");
            //    running = true;


            //}
            //else
            //{
            //    // Stop the process
            //    process.Kill();
            //    running = false;


            //}






            //string WEBUIpath = "webui-user.bat"; // 定义文件路径
            //Process process = new Process(); // 定义进程对象
            //process.StartInfo.FileName = WEBUIpath; // 设置要启动的程序名称
            //process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // 隐藏进程窗口
            //process.Start(); // 启动进程
            //启动按钮.Content=("正在运行");

            //Console.ReadKey(); // 等待用户按下按钮

            //process.Close(); // 关闭进程
            //启动按钮.Content=("一键启动");
        }








        private void BILIBILI_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            //Use no more than one assignment when you test this code.
            //string target = "ftp://ftp.microsoft.com";
            //string target = "C:\\Program Files\\Microsoft Visual Studio\\INSTALL.HTM";
            try
            {
                Process.Start(new ProcessStartInfo("https://space.bilibili.com/666714573") { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void WebuiGITHUB_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            //Use no more than one assignment when you test this code.
            //string target = "ftp://ftp.microsoft.com";
            //string target = "C:\\Program Files\\Microsoft Visual Studio\\INSTALL.HTM";
            try
            {
                Process.Start(new ProcessStartInfo("https://github.com/AUTOMATIC1111/stable-diffusion-webui") { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void AI绘画相册_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // 获取当前程序的路径
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // 获取当前程序同目录下的outputs文件夹路径
            string outputsDirectory = currentDirectory + "outputs";
            // 使用Windows文件管理器打开outputs文件夹
            Process.Start("explorer.exe", outputsDirectory);
        }

        private void 文件夹按钮_Click(object sender, RoutedEventArgs e)
        {
            string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start("explorer.exe", currentDirectory);
        }





        private void OpenAI_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://openai.com") { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        private void BILIBILI_MouseMove(object sender, MouseEventArgs e)
        {
            作者信息.Text = ("启动器作者@Harekaze晴风 B站主页");
            作者信息.Opacity = 1.0;
        }

        private void BILIBILI_MouseLeave(object sender, MouseEventArgs e)
        {
            作者信息.Text = ("");
            作者信息.Opacity = 0.0;
        }

        private void WebuiGITHUB_MouseMove(object sender, MouseEventArgs e)
        {
            Github信息.Text = ("Stable-Diffusion WebUI  Github主页");
            Github信息.Opacity = 1.0;
        }

        private void WebuiGITHUB_MouseLeave(object sender, MouseEventArgs e)
        {
            Github信息.Text = ("");
            Github信息.Opacity = 0.0;
        }

        private void OpenAI_MouseMove(object sender, MouseEventArgs e)
        {
            OpenAI信息.Text = ("OpenAI  官 方 网 站");
            OpenAI信息.Opacity = 1.0;
        }

        private void OpenAI_MouseLeave(object sender, MouseEventArgs e)
        {
            OpenAI信息.Text = ("");
            OpenAI信息.Opacity = 0.0;
        }
        private void qq频道_MouseMove(object sender, MouseEventArgs e)
        {
            QQ频道号.Text = ("晴风港QQ频道号:j7jw4rb2r2,欢迎来玩");
            QQ二维码图片.Opacity = 100;
            SD安装按钮.Opacity = 0.0;
        }
        private void qq频道_MouseLeave(object sender, MouseEventArgs e)
        {
            QQ频道号.Text = ("");
            QQ二维码图片.Opacity = 0;
            SD安装按钮.Opacity = 1.0;
        }

        //private void qq频道_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    if(QQ二维码图片.Opacity== 0)
        //    {QQ频道号.Text = ("QQ频道号:j7jw4rb2r2");
        //        QQ二维码图片.Opacity = 100; }

        //    else {QQ频道号.Text = ("");
        //        QQ二维码图片.Opacity = 0; }



        //}









        private void 浏览器自动加载按钮_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 获取当前工作目录
            string currentDirectory = Directory.GetCurrentDirectory();
            // 获取webui-user.bat的完整路径
            string filePath = System.IO.Path.Combine(currentDirectory, "webui-user.bat");
            // 读取文件内容
            string[] lines = File.ReadAllLines(filePath);
            // 遍历每一行
            for (int i = 0; i < lines.Length; i++)
            {
                // 如果当前行是 set COMMANDLINE_ARGS= 开头
                if (lines[i].StartsWith("set COMMANDLINE_ARGS="))
                {
                    // 获取当前行的参数
                    string[] argsArray = lines[i].Split('=').Last().Split(' ');
                    // 判断是否有 --theme dark
                    if (argsArray.Contains("--autolaunch"))
                    {
                        // 有的话删除
                        argsArray = argsArray.Where(x => x != "--autolaunch").ToArray();

                        浏览器自启动信息显示.Text = ("浏览器自启动已关闭");
                        浏览器自动加载按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    }
                    else
                    {
                        // 没有的话插入
                        string[] newArgsArray = new string[argsArray.Length + 1];
                        Array.Copy(argsArray, newArgsArray, argsArray.Length);
                        newArgsArray[newArgsArray.Length - 1] = "--autolaunch";
                        argsArray = newArgsArray;
                        浏览器自启动信息显示.Text = ("浏览器自启动已开启");
                        浏览器自动加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));

                    }
                    // 将修改后的参数重新拼成字符串
                    lines[i] = "set COMMANDLINE_ARGS=" + string.Join(" ", argsArray);
                }
            }
            // 将修改后的内容写入文件
            File.WriteAllLines(filePath, lines);
        }

        private void danbooru加载按钮_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 获取当前工作目录
            string currentDirectory = Directory.GetCurrentDirectory();
            // 获取webui-user.bat的完整路径
            string filePath = System.IO.Path.Combine(currentDirectory, "webui-user.bat");
            // 读取文件内容
            string[] lines = File.ReadAllLines(filePath);
            // 遍历每一行
            for (int i = 0; i < lines.Length; i++)
            {
                // 如果当前行是 set COMMANDLINE_ARGS= 开头
                if (lines[i].StartsWith("set COMMANDLINE_ARGS="))
                {
                    // 获取当前行的参数
                    string[] argsArray = lines[i].Split('=').Last().Split(' ');
                    // 判断是否有 --deepdanbooru
                    if (argsArray.Contains("--deepdanbooru"))
                    {
                        // 有的话删除
                        argsArray = argsArray.Where(x => x != "--deepdanbooru").ToArray();
                        danbooru状态显示.Text = ("Deepdanbooru已关闭");
                        danbooru加载按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    }
                    else
                    {
                        // 没有的话插入
                        string[] newArgsArray = new string[argsArray.Length + 1];
                        Array.Copy(argsArray, newArgsArray, argsArray.Length);
                        newArgsArray[newArgsArray.Length - 1] = "--deepdanbooru";
                        argsArray = newArgsArray;

                        danbooru状态显示.Text = ("Deepdanbooru已开启");
                        danbooru加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    }
                    // 将修改后的参数重新拼成字符串
                    lines[i] = "set COMMANDLINE_ARGS=" + string.Join(" ", argsArray);
                }
            }
            // 将修改后的内容写入文件
            File.WriteAllLines(filePath, lines);
        }

        private void Xformer加载按钮_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 获取当前工作目录
            string currentDirectory = Directory.GetCurrentDirectory();
            // 获取webui-user.bat的完整路径
            string filePath = System.IO.Path.Combine(currentDirectory, "webui-user.bat");
            // 读取文件内容
            string[] lines = File.ReadAllLines(filePath);
            // 遍历每一行
            for (int i = 0; i < lines.Length; i++)
            {
                // 如果当前行是 set COMMANDLINE_ARGS= 开头
                if (lines[i].StartsWith("set COMMANDLINE_ARGS="))
                {
                    // 获取当前行的参数
                    string[] argsArray = lines[i].Split('=').Last().Split(' ');
                    // 判断是否有 --force-enable-xformers --xformers
                    if (argsArray.Contains("--xformers"))
                    {
                        // 有的话删除
                        argsArray = argsArray.Where(x => x != "--xformers").ToArray();
                        Xformer状态显示.Text = ("Xformer已关闭");
                        Xformer加载按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    }
                    else
                    {
                        // 没有的话插入
                        string[] newArgsArray = new string[argsArray.Length + 1];
                        Array.Copy(argsArray, newArgsArray, argsArray.Length);
                        newArgsArray[newArgsArray.Length - 1] = "--xformers";
                        argsArray = newArgsArray;

                        Xformer状态显示.Text = ("Xformer已开启");
                        Xformer加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    }
                    // 将修改后的参数重新拼成字符串
                    lines[i] = "set COMMANDLINE_ARGS=" + string.Join(" ", argsArray);
                }
            }

            for (int i = 0; i < lines.Length; i++)
            {
                // 如果当前行是 set COMMANDLINE_ARGS= 开头
                if (lines[i].StartsWith("set COMMANDLINE_ARGS="))
                {
                    // 获取当前行的参数
                    string[] argsArray = lines[i].Split('=').Last().Split(' ');
                    // 判断是否有 --force-enable-xformers --xformers
                    if (argsArray.Contains("--force-enable-xformers"))
                    {
                        // 有的话删除
                        argsArray = argsArray.Where(x => x != "--force-enable-xformers").ToArray();
                        Xformer状态显示.Text = ("Xformer已关闭");
                        Xformer加载按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    }
                    else
                    {
                        // 没有的话插入
                        string[] newArgsArray = new string[argsArray.Length + 1];
                        Array.Copy(argsArray, newArgsArray, argsArray.Length);
                        newArgsArray[newArgsArray.Length - 1] = "--force-enable-xformers";
                        argsArray = newArgsArray;

                        Xformer状态显示.Text = ("Xformer已开启");
                        Xformer加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    }
                    // 将修改后的参数重新拼成字符串
                    lines[i] = "set COMMANDLINE_ARGS=" + string.Join(" ", argsArray);
                }
            }
            // 将修改后的内容写入文件
            File.WriteAllLines(filePath, lines);
        }

        private void 半精度加载按钮_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 获取当前工作目录
            string currentDirectory = Directory.GetCurrentDirectory();
            // 获取webui-user.bat的完整路径
            string filePath = System.IO.Path.Combine(currentDirectory, "webui-user.bat");
            // 读取文件内容
            string[] lines = File.ReadAllLines(filePath);
            // 遍历每一行
            for (int i = 0; i < lines.Length; i++)
            {
                // 如果当前行是 set COMMANDLINE_ARGS= 开头
                if (lines[i].StartsWith("set COMMANDLINE_ARGS="))
                {
                    // 获取当前行的参数
                    string[] argsArray = lines[i].Split('=').Last().Split(' ');
                    // 判断是否有 --no-half
                    if (argsArray.Contains("--no-half"))
                    {
                        // 有的话删除
                        argsArray = argsArray.Where(x => x != "--no-half").ToArray();
                        计算精度状态显示.Text = ("混合精度运算开启");
                        半精度加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 78, 85, 255));
                    }
                    else
                    {
                        // 没有的话插入
                        string[] newArgsArray = new string[argsArray.Length + 1];
                        Array.Copy(argsArray, newArgsArray, argsArray.Length);
                        newArgsArray[newArgsArray.Length - 1] = "--no-half";
                        argsArray = newArgsArray;

                        计算精度状态显示.Text = ("全精度运算已开启");
                        半精度加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    }
                    // 将修改后的参数重新拼成字符串
                    lines[i] = "set COMMANDLINE_ARGS=" + string.Join(" ", argsArray);

                }
            }
            // 将修改后的内容写入文件
            File.WriteAllLines(filePath, lines);
        }
        //
        private void 低显存加载按钮_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 获取当前工作目录
            string currentDirectory = Directory.GetCurrentDirectory();
            // 获取webui-user.bat的完整路径
            string filePath = System.IO.Path.Combine(currentDirectory, "webui-user.bat");
            // 读取文件内容
            string[] lines = File.ReadAllLines(filePath);
            // 遍历每一行
            for (int i = 0; i < lines.Length; i++)
            {
                // 如果当前行是 set COMMANDLINE_ARGS= 开头
                if (lines[i].StartsWith("set COMMANDLINE_ARGS="))
                {
                    // 获取当前行的参数
                    string[] argsArray = lines[i].Split('=').Last().Split(' ');
                    // 判断是否有 --no-half
                    if (argsArray.Contains("--lowvram"))
                    {
                        // 有的话删除
                        argsArray = argsArray.Where(x => x != "--lowvram").ToArray();
                        低显存模式显示.Text = ("低显存模式已关闭");
                        低显存加载按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    }
                    else
                    {
                        // 没有的话插入
                        string[] newArgsArray = new string[argsArray.Length + 1];
                        Array.Copy(argsArray, newArgsArray, argsArray.Length);
                        newArgsArray[newArgsArray.Length - 1] = "--lowvram";
                        argsArray = newArgsArray;

                        低显存模式显示.Text = ("低显存模式已开启\n请关闭Xformer");
                        低显存加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    }
                    // 将修改后的参数重新拼成字符串
                    lines[i] = "set COMMANDLINE_ARGS=" + string.Join(" ", argsArray);

                }
            }
            // 将修改后的内容写入文件
            File.WriteAllLines(filePath, lines);
        }

        //private void CPU模式加载按钮_MouseDown(object sender, MouseButtonEventArgs e)
        //{

        //    // 获取当前工作目录
        //    string currentDirectory = Directory.GetCurrentDirectory();
        //    // 获取webui-user.bat的完整路径
        //    string filePath = System.IO.Path.Combine(currentDirectory, "webui-user.bat");
        //    // 读取文件内容
        //    string[] lines = File.ReadAllLines(filePath);
        //    // 遍历每一行
        //    for (int i = 0; i < lines.Length; i++)
        //    {
        //        // 如果当前行是 set COMMANDLINE_ARGS= 开头
        //        if (lines[i].StartsWith("set COMMANDLINE_ARGS="))
        //        {
        //            // 获取当前行的参数
        //            string[] argsArray = lines[i].Split('=').Last().Split(' ');
        //            // 判断是否有 --no-half
        //            //if (argsArray.Contains("--use-cpu all --skip-torch-cuda-tests"))

        //            //if (File.Exists(filePath))
        //            //{
        //            //string fileContent = File.ReadAllText(filePath);
        //            //if (fileContent.Contains("--use-cpu all --skip-torch-cuda-tests"))
        //            if (CPU模式信息.Text == "已禁用CUDA检测")
        //            {
        //                // 有的话删除
        //                argsArray = argsArray.Where(x => x != "--skip-torch-cuda-tests").ToArray();

        //                // 获取当前目录
        //                string currentDirectory1 = Directory.GetCurrentDirectory();
        //                // 定义文件路径
        //                string filePath2 = System.IO.Path.Combine(currentDirectory1, "webui-user.bat");
        //                // 读取文件内容
        //                string fileContent2 = File.ReadAllText(filePath2);
        //                // 删除“--use-cpu all --skip-torch-cuda-tests”
        //                fileContent2 = fileContent2.Replace("--skip-torch-cuda-tests", "");
        //                // 将修改后的内容写入文件
        //                File.WriteAllText(filePath2, fileContent2);












        //                CPU模式信息.Text = ("CPU模式已关闭");
        //                CPU模式加载按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
        //            }

        //            else
        //            {
        //                // 没有的话插入
        //                string[] newArgsArray = new string[argsArray.Length + 1];
        //                Array.Copy(argsArray, newArgsArray, argsArray.Length);
        //                newArgsArray[newArgsArray.Length - 1] = "--skip-torch-cuda-tests";
        //                argsArray = newArgsArray;

        //                CPU模式信息.Text = ("CPU模式已开启\n请关闭Xformer");
        //                CPU模式加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
        //            }

        //            // 将修改后的参数重新拼成字符串
        //            lines[i] = "set COMMANDLINE_ARGS=" + string.Join(" ", argsArray);
        //            //}
        //        }
        //    }

        //    // 将修改后的内容写入文件
        //    File.WriteAllLines(filePath, lines);
        //}

        private void Python安装按钮_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Use no more than one assignment when you test this code.
            //string target = "ftp://ftp.microsoft.com";
            //string target = "C:\\Program Files\\Microsoft Visual Studio\\INSTALL.HTM";
            try
            {
                Process.Start(new ProcessStartInfo("https://www.python.org") { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void Git安装按钮_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Use no more than one assignment when you test this code.
            //string target = "ftp://ftp.microsoft.com";
            //string target = "C:\\Program Files\\Microsoft Visual Studio\\INSTALL.HTM";
            try
            {
                Process.Start(new ProcessStartInfo("https://gitforwindows.org/") { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void 公网分享按钮_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 获取当前工作目录
            string currentDirectory = Directory.GetCurrentDirectory();
            // 获取webui-user.bat的完整路径
            string filePath = System.IO.Path.Combine(currentDirectory, "webui-user.bat");
            // 读取文件内容
            string[] lines = File.ReadAllLines(filePath);
            // 遍历每一行
            for (int i = 0; i < lines.Length; i++)
            {
                // 如果当前行是 set COMMANDLINE_ARGS= 开头
                if (lines[i].StartsWith("set COMMANDLINE_ARGS="))
                {
                    // 获取当前行的参数
                    string[] argsArray = lines[i].Split('=').Last().Split(' ');
                    // 判断是否有 --deepdanbooru
                    if (argsArray.Contains("--share"))
                    {
                        // 有的话删除
                        argsArray = argsArray.Where(x => x != "--share").ToArray();
                        分享到公共网络.Text = ("公网分享已关闭");
                        公网分享按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    }
                    else
                    {
                        // 没有的话插入
                        string[] newArgsArray = new string[argsArray.Length + 1];
                        Array.Copy(argsArray, newArgsArray, argsArray.Length);
                        newArgsArray[newArgsArray.Length - 1] = "--share";
                        argsArray = newArgsArray;

                        分享到公共网络.Text = ("公网分享已开启");
                        公网分享按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    }
                    // 将修改后的参数重新拼成字符串
                    lines[i] = "set COMMANDLINE_ARGS=" + string.Join(" ", argsArray);
                }
            }
            // 将修改后的内容写入文件
            File.WriteAllLines(filePath, lines);
        }

        private void 低内存模式加载按钮_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 获取当前工作目录
            string currentDirectory = Directory.GetCurrentDirectory();
            // 获取webui-user.bat的完整路径
            string filePath = System.IO.Path.Combine(currentDirectory, "webui-user.bat");
            // 读取文件内容
            string[] lines = File.ReadAllLines(filePath);
            // 遍历每一行
            for (int i = 0; i < lines.Length; i++)
            {
                // 如果当前行是 set COMMANDLINE_ARGS= 开头
                if (lines[i].StartsWith("set COMMANDLINE_ARGS="))
                {
                    // 获取当前行的参数
                    string[] argsArray = lines[i].Split('=').Last().Split(' ');
                    // 判断是否有 --deepdanbooru
                    if (argsArray.Contains("--lowram"))
                    {
                        // 有的话删除
                        argsArray = argsArray.Where(x => x != "--lowram").ToArray();
                        内存模式信息.Text = (" 低内存模式已关闭");
                        低内存模式加载按钮.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    }
                    else
                    {
                        // 没有的话插入
                        string[] newArgsArray = new string[argsArray.Length + 1];
                        Array.Copy(argsArray, newArgsArray, argsArray.Length);
                        newArgsArray[newArgsArray.Length - 1] = "--lowram";
                        argsArray = newArgsArray;

                        内存模式信息.Text = (" 低内存模式已开启");
                        低内存模式加载按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    }
                    // 将修改后的参数重新拼成字符串
                    lines[i] = "set COMMANDLINE_ARGS=" + string.Join(" ", argsArray);
                }
            }
            // 将修改后的内容写入文件
            File.WriteAllLines(filePath, lines);
        }











        private void SD安装按钮_MouseMove(object sender, MouseEventArgs e)
        {
            SD安装按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 28));
            SD下载信息.Text = ("(需要Git)获取最新的WebUI");
        }

        private void SD安装按钮_MouseLeave(object sender, MouseEventArgs e)
        {
            SD安装按钮.Background = new SolidColorBrush(Color.FromArgb(0, 0, 219, 28));
            SD下载信息.Text = ("");
        }




        private void 最小化按钮_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void 关闭按钮_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.Close();
        }



        private void dis频道_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://discord.gg/c8JFnscV") { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }



        private void SD安装按钮_MouseDown_1(object sender, MouseButtonEventArgs e)
        {



            // 下载文件的地址
            string downloadUrl = "https://github.com/AUTOMATIC1111/stable-diffusion-webui/archive/refs/heads/master.zip";
            // 解压后的文件存放的地址
            string unzipPath = Directory.GetCurrentDirectory();


            // 创建WebClient对象
            using (WebClient webClient = new WebClient())
            {
                // 下载文件
                try
                {
                    webClient.DownloadFile(downloadUrl, "master.zip");
                }
                catch { }
                // 如果解压后的文件已经存在，则删除
                if (Directory.Exists(unzipPath + "\\stable-diffusion-webui-master"))
                {
                    Directory.Delete(unzipPath + "\\stable-diffusion-webui-master", true);
                }
                try
                {
                    // 解压文件
                    ZipFile.ExtractToDirectory("master.zip", unzipPath);

                    // 获取程序所在目录
                    string currDir = Directory.GetCurrentDirectory();
                    // 获取stable-diffusion-webui-master文件夹的路径
                    string srcDir = System.IO.Path.Combine(currDir, "stable-diffusion-webui-master");

                    string sourceDir = "stable-diffusion-webui-master";
                    string targetDir = Directory.GetCurrentDirectory();
                }
                catch { }




                // 获取程序所在目录
                string currentDirectory = Directory.GetCurrentDirectory();
                // 获取stable-diffusion-webui-master文件夹路径
                string sourceDirectory = System.IO.Path.Combine(currentDirectory, "stable-diffusion-webui-master");
                // 判断文件夹是否存在
                if (Directory.Exists(sourceDirectory))
                {
                    // 复制文件夹中的所有文件及子文件夹
                    DirectoryCopy(sourceDirectory, currentDirectory, true);
                    Console.WriteLine("文件复制完成！");
                    启动按钮.Content = "一键启动";
                    启动按钮.Background = new SolidColorBrush(Color.FromArgb(255, 255, 200, 10));
                    本地版本信息.Text = ("Stable Diffusion\n WebUI已安装");

                }
                else
                {
                    Console.WriteLine("未找到stable-diffusion-webui-master文件夹！");
                }
            }


            // 复制文件夹的方法
            static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
            {
                // 获取源文件夹信息
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);
                // 创建目标文件夹
                Directory.CreateDirectory(destDirName);
                // 获取文件信息
                FileInfo[] files = dir.GetFiles();
                // 复制文件
                foreach (FileInfo file in files)
                {
                    string tempPath = System.IO.Path.Combine(destDirName, file.Name);
                    file.CopyTo(tempPath, true);
                }
                // 判断是否需要复制子文件夹
                if (copySubDirs)
                {
                    // 获取子文件夹信息
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    // 遍历子文件夹并复制
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string tempPath = System.IO.Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, tempPath, copySubDirs);

                    }

                }

                //// Check if source directory exists
                //if (Directory.Exists(sourceDir))
                //{
                //    // Get all files in the source directory
                //    string[] files = Directory.GetFiles(sourceDir, "*", SearchOption.AllDirectories);

                //    // Copy each file to the target directory
                //    foreach (string file in files)
                //    {
                //        string targetFile = System.IO.Path.Combine(targetDir, file.Substring(sourceDir.Length + 1));
                //        File.Copy(file, targetFile, true);

                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Source directory does not exist.");
                //}
                //// 判断文件夹是否存在
                //if (Directory.Exists(srcDir))
                //        {
                //            // 获取所有文件的路径
                //            string[] files = Directory.GetFiles(srcDir);
                //            // 遍历文件
                //            foreach (string file in files)
                //            {
                //                // 获取文件名
                //                string fileName = System.IO.Path.GetFileName(file);
                //                // 设置文件的目标路径
                //                string destFile = System.IO.Path.Combine(currDir, fileName);
                //                // 复制文件，如果目标文件存在则覆盖
                //                File.Copy(file, destFile, true);
                //            }
                //            启动按钮.Content = "一键启动";
                //            启动按钮.Background = new SolidColorBrush(Color.FromArgb(255, 255, 200, 10));
                //            本地版本信息.Text = ("Stable Diffusion WebUI已安装");
                //        }
                //        else
                //        {
                //            Console.WriteLine("stable-diffusion-webui-master文件夹不存在！");
                //        }
            }



            //string downloadUrl = "https://github.com/AUTOMATIC1111/stable-diffusion-webui/archive/refs/heads/master.zip";
            //string folderName = "stable-diffusion-webui-master";
            //string zipFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\" + folderName + ".zip";
            //string extractPath = AppDomain.CurrentDomain.BaseDirectory + "\\" + folderName;

            //try
            //{
            //    // 下载zip文件
            //    using (WebClient client = new WebClient())
            //    {
            //        client.DownloadFile(downloadUrl, zipFilePath);
            //    }

            //    // 如果解压后的文件夹已经存在，则删除
            //    if (Directory.Exists(extractPath))
            //    {
            //        Directory.Delete(extractPath, true);
            //    }

            //    // 解压zip文件
            //    ZipFile.ExtractToDirectory(zipFilePath, extractPath);

            //    // 将解压后的文件夹内的所有文件写入到程序所在目录
            //    foreach (string file in Directory.GetFiles(extractPath))
            //    {
            //        File.Copy(file, AppDomain.CurrentDomain.BaseDirectory + "\\" + System.IO.Path.GetFileName(file), true);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("下载失败：" + ex.Message);
            //}
            //string fileUrl = "https://github.com/AUTOMATIC1111/stable-diffusion-webui/archive/refs/heads/master.zip";
            //string fileName = "stable-diffusion-webui.zip";
            //string filePath = System.IO.Path.Combine(Environment.CurrentDirectory, fileName);
            //string unzipFolder = System.IO.Path.Combine(Environment.CurrentDirectory, "stable-diffusion-webui");

            //// 下载文件
            //try
            //{
            //    using (WebClient webClient = new WebClient())
            //    {
            //        webClient.DownloadFile(fileUrl, filePath);
            //    }
            //}
            //catch (WebException ex)
            //{
            //    MessageBox.Show("下载文件失败：" + ex.Message);
            //    return;
            //}

            //// 解压文件
            //try
            //{
            //    if (Directory.Exists(unzipFolder))
            //    {
            //        // 如果解压后的文件夹已经存在，则比较文件是否相同
            //        bool isSame = true;
            //        string[] fileList = Directory.GetFiles(unzipFolder, "*", SearchOption.AllDirectories);
            //        foreach (string file in fileList)
            //        {
            //            if (!File.Exists(file))
            //            {
            //                isSame = false;
            //                break;
            //            }
            //        }
            //        if (isSame)
            //        {
            //            // 解压后的文件夹内的文件全部都存在，不做处理
            //            MessageBox.Show("解压后的文件夹内的文件全部都存在，无需再次解压");
            //            return;
            //        }
            //        else
            //        {
            //            // 解压后的文件夹内的文件有部分不存在，删除解压后的文件夹并重新解压
            //            Directory.Delete(unzipFolder, true);
            //        }
            //    }
            //    System.IO.Compression.ZipFile.ExtractToDirectory(filePath, unzipFolder);
            //}
            //catch (IOException ex)
            //{
            //    MessageBox.Show("解压文件失败：" + ex.Message);
            //    return;
            //}




        }

        private void title_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void SD文件按钮_MouseDown(object sender, MouseButtonEventArgs e)
        {
            {
                // Get the current directory of the program
                string currDir = System.IO.Directory.GetCurrentDirectory();


                // Set the command to be executed in CMD
                string command1 = currDir + @"\venv\Scripts\python.exe -m pip install -i https://pypi.tuna.tsinghua.edu.cn/simple --upgrade pip";
                string command2 = currDir + @"\venv\Scripts\python.exe -m  pip config set global.index-url https://pypi.tuna.tsinghua.edu.cn/simple";

                // Execute the command in CMD
                Process.Start("cmd.exe", "/c " + command1);
                Process.Start("cmd.exe", "/c " + command2);

                try
                {
                    Process.Start(new ProcessStartInfo("https://steampp.net/") { UseShellExecute = true });
                }
                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message);
                }
                catch (System.Exception other)
                {
                    MessageBox.Show(other.Message);
                }
                try
                {
                    Process.Start(new ProcessStartInfo("https://github.com/docmirror/dev-sidecar") { UseShellExecute = true });
                }
                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message);
                }
                catch (System.Exception other)
                {
                    MessageBox.Show(other.Message);
                }

            }
        }

        private void SD文件按钮_MouseMove(object sender, MouseEventArgs e)
        {
            SD文件按钮.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 28));
            SD下载信息.Text = ("启动修复");
        }

        private void SD文件按钮_MouseLeave(object sender, MouseEventArgs e)
        {
            SD文件按钮.Background = new SolidColorBrush(Color.FromArgb(0, 0, 219, 28));
            SD下载信息.Text = ("");
        }















        private void Dreanmbooth_MouseDown(object sender, MouseButtonEventArgs e)
        {

            string extensionsPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "extensions");
            string sdDreamboothPath = System.IO.Path.Combine(extensionsPath, "sd_dreambooth_extension");

            // 检测文件夹是否存在
            if (Directory.Exists(extensionsPath))
            {
                // 如果文件夹存在，则检测 sd_dreambooth_extension 文件夹是否存在
                if (Directory.Exists(sdDreamboothPath))
                {
                    // 如果 sd_dreambooth_extension 文件夹存在，则删除它
                    try
                    {

                        FileSystem.DeleteDirectory(sdDreamboothPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        Dreanmbooth.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                        Dreambooth信息显示.Text = ("Dreambooth未安装");
                    }
                    catch { }



                }
                else
                {
                    // 如果 sd_dreambooth_extension 文件夹不存在，则在终端中执行 git clone 命令
                    // 使用 Process 类执行终端命令
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = "git";
                        process.StartInfo.Arguments = "clone https://github.com/d8ahazard/sd_dreambooth_extension.git";
                        process.StartInfo.WorkingDirectory = extensionsPath;
                        process.Start();
                        process.WaitForExit();
                    }


                    Dreanmbooth.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    Dreambooth信息显示.Text = ("Dreambooth已安装");

                }
            }

        }

        private void 嵌入编辑器_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string extensionsPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "extensions");
            string sdDreamboothPath = System.IO.Path.Combine(extensionsPath, "stable-diffusion-webui-embedding-editor");

            // 检测文件夹是否存在
            if (Directory.Exists(extensionsPath))
            {
                // 如果文件夹存在，则检测 sd_dreambooth_extension 文件夹是否存在
                if (Directory.Exists(sdDreamboothPath))
                {
                    // 如果 sd_dreambooth_extension 文件夹存在，则删除它
                    try
                    {

                        FileSystem.DeleteDirectory(sdDreamboothPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    }
                    catch { }

                    嵌入编辑器.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    嵌入编辑器状态显示.Text = ("嵌入编辑器未安装");

                }
                else
                {
                    // 如果 sd_dreambooth_extension 文件夹不存在，则在终端中执行 git clone 命令
                    // 使用 Process 类执行终端命令
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = "git";
                        process.StartInfo.Arguments = "clone https://github.com/CodeExplode/stable-diffusion-webui-embedding-editor.git";
                        process.StartInfo.WorkingDirectory = extensionsPath;
                        process.Start();
                        process.WaitForExit();
                    }


                    嵌入编辑器.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    嵌入编辑器状态显示.Text = ("嵌入编辑器已安装");

                }
            }

        }

        private void 声纳_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string extensionsPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "extensions");
            string sdDreamboothPath = System.IO.Path.Combine(extensionsPath, "stable-diffusion-webui-sonar");

            // 检测文件夹是否存在
            if (Directory.Exists(extensionsPath))
            {
                // 如果文件夹存在，则检测 sd_dreambooth_extension 文件夹是否存在
                if (Directory.Exists(sdDreamboothPath))
                {
                    // 如果 sd_dreambooth_extension 文件夹存在，则删除它
                    try
                    {

                        FileSystem.DeleteDirectory(sdDreamboothPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    }
                    catch { }

                    声纳.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    声纳状态显示.Text = ("声纳未安装");

                }
                else
                {
                    // 如果 sd_dreambooth_extension 文件夹不存在，则在终端中执行 git clone 命令
                    // 使用 Process 类执行终端命令
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = "git";
                        process.StartInfo.Arguments = "clone https://github.com/Kahsolt/stable-diffusion-webui-sonar.git";
                        process.StartInfo.WorkingDirectory = extensionsPath;
                        process.Start();
                        process.WaitForExit();
                    }


                    声纳.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    声纳状态显示.Text = ("声纳已安装");

                }
            }
        }

        private void booru2prompt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string extensionsPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "extensions");
            string sdDreamboothPath = System.IO.Path.Combine(extensionsPath, "booru2prompt");

            // 检测文件夹是否存在
            if (Directory.Exists(extensionsPath))
            {
                // 如果文件夹存在，则检测 sd_dreambooth_extension 文件夹是否存在
                if (Directory.Exists(sdDreamboothPath))
                {
                    // 如果 sd_dreambooth_extension 文件夹存在，则删除它
                    try
                    {

                        FileSystem.DeleteDirectory(sdDreamboothPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    }
                    catch { }

                    booru2prompt.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    booru2prompt模式显示.Text = ("Booru反推未安装");

                }
                else
                {
                    // 如果 sd_dreambooth_extension 文件夹不存在，则在终端中执行 git clone 命令
                    // 使用 Process 类执行终端命令
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = "git";
                        process.StartInfo.Arguments = "clone https://github.com/CodeExplode/stable-diffusion-webui-embedding-editor.git";
                        process.StartInfo.WorkingDirectory = extensionsPath;
                        process.Start();
                        process.WaitForExit();
                    }


                    booru2prompt.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    booru2prompt模式显示.Text = ("booru反推已安装");

                }
            }
        }

        private void 深度图_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string extensionsPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "extensions");
            string sdDreamboothPath = System.IO.Path.Combine(extensionsPath, "stable-diffusion-webui-depthmap-script");

            // 检测文件夹是否存在
            if (Directory.Exists(extensionsPath))
            {
                // 如果文件夹存在，则检测 sd_dreambooth_extension 文件夹是否存在
                if (Directory.Exists(sdDreamboothPath))
                {
                    // 如果 sd_dreambooth_extension 文件夹存在，则删除它
                    try
                    {

                        FileSystem.DeleteDirectory(sdDreamboothPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    }
                    catch { }

                    深度图.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    深度图模式信息.Text = ("深度图未安装");

                }
                else
                {
                    // 如果 sd_dreambooth_extension 文件夹不存在，则在终端中执行 git clone 命令
                    // 使用 Process 类执行终端命令
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = "git";
                        process.StartInfo.Arguments = "clone https://github.com/thygate/stable-diffusion-webui-depthmap-script.git";
                        process.StartInfo.WorkingDirectory = extensionsPath;
                        process.Start();
                        process.WaitForExit();
                    }


                    深度图.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    深度图模式信息.Text = ("深度图已安装");

                }
            }
        }

        private void 历史图库_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string extensionsPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "extensions");
            string sdDreamboothPath = System.IO.Path.Combine(extensionsPath, "stable-diffusion-webui-images-browser");

            // 检测文件夹是否存在
            if (Directory.Exists(extensionsPath))
            {
                // 如果文件夹存在，则检测 sd_dreambooth_extension 文件夹是否存在
                if (Directory.Exists(sdDreamboothPath))
                {
                    // 如果 sd_dreambooth_extension 文件夹存在，则删除它
                    try
                    {

                        FileSystem.DeleteDirectory(sdDreamboothPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    }
                    catch { }

                    历史图库.Background = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
                    历史图库状态显示.Text = ("图像浏览器未安装");

                }
                else
                {
                    // 如果 sd_dreambooth_extension 文件夹不存在，则在终端中执行 git clone 命令
                    // 使用 Process 类执行终端命令
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = "git";
                        process.StartInfo.Arguments = "clone https://github.com/yfszzx/stable-diffusion-webui-images-browser.git";
                        process.StartInfo.WorkingDirectory = extensionsPath;
                        process.Start();
                        process.WaitForExit();
                    }


                    历史图库.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
                    历史图库状态显示.Text = ("图像浏览器已安装");

                }
            }
        }

        private void emb模型管理_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 获取当前程序所在目录
            string currentDirectory = Directory.GetCurrentDirectory();


            // 拼接出 embeddings 文件夹的路径
            string embeddingsPath = System.IO.Path.Combine(currentDirectory, "embeddings");

            // 判断文件夹是否存在
            if (Directory.Exists(embeddingsPath))
            {
                // 如果存在，使用文件管理器打开该文件夹
                System.Diagnostics.Process.Start("explorer.exe", embeddingsPath);
            }
            else
            {

            }
        }
        private void emb模型管理_MouseMove(object sender, MouseEventArgs e)
        {
            emb模型管理.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));

        }

        private void emb模型管理_MouseLeave(object sender, MouseEventArgs e)
        {
            emb模型管理.Background = new SolidColorBrush(Color.FromArgb(0, 0, 219, 18));

        }

        private void hyp模型文件管理_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 获取当前程序所在目录
            string currentDirectory = Directory.GetCurrentDirectory();

            // 检查models\Stable-diffusion文件夹是否存在
            string targetDirectory = System.IO.Path.Combine(currentDirectory, "models", "hypernetworks");
            if (Directory.Exists(targetDirectory))
            {
                // 用文件管理器打开该文件夹
                System.Diagnostics.Process.Start("explorer.exe", targetDirectory);
            }
            else
            {

            }

        }

        private void hyp模型文件管理_MouseMove(object sender, MouseEventArgs e)
        {
            hyp模型文件管理.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));

        }

        private void hyp模型文件管理_MouseLeave(object sender, MouseEventArgs e)
        {
            hyp模型文件管理.Background = new SolidColorBrush(Color.FromArgb(0, 0, 219, 18));

        }

        private void ckpt模型管理_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 获取当前程序所在目录
            string currentDirectory = Directory.GetCurrentDirectory();

            // 检查models\Stable-diffusion文件夹是否存在
            string targetDirectory = System.IO.Path.Combine(currentDirectory, "models", "Stable-diffusion");
            if (Directory.Exists(targetDirectory))
            {
                // 用文件管理器打开该文件夹
                System.Diagnostics.Process.Start("explorer.exe", targetDirectory);
            }
            else
            {

            }
        }

        private void ckpt模型管理_MouseMove(object sender, MouseEventArgs e)
        {
            ckpt模型管理.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));

        }

        private void ckpt模型管理_MouseLeave(object sender, MouseEventArgs e)
        {
            ckpt模型管理.Background = new SolidColorBrush(Color.FromArgb(0, 0, 219, 18));

        }

        private void vae模型文件管理_MouseDown(object sender, MouseButtonEventArgs e)
        {

            // 获取当前程序所在目录
            string currentDirectory = Directory.GetCurrentDirectory();

            // 检查models\Stable-diffusion文件夹是否存在
            string targetDirectory = System.IO.Path.Combine(currentDirectory, "models", "VAE");
            if (Directory.Exists(targetDirectory))
            {
                // 用文件管理器打开该文件夹
                System.Diagnostics.Process.Start("explorer.exe", targetDirectory);
            }
            else
            {
                MessageBox.Show("请先安装一个版本");
            }
        }

        private void vae模型文件管理_MouseMove(object sender, MouseEventArgs e)
        {
            vae模型文件管理.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));

        }

        private void vae模型文件管理_MouseLeave(object sender, MouseEventArgs e)
        {
            vae模型文件管理.Background = new SolidColorBrush(Color.FromArgb(0, 0, 219, 18));

        }

        private void 更多扩展_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Extensions") { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }

        }

        private void 更多扩展_MouseMove(object sender, MouseEventArgs e)
        {
            更多扩展.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
        }

        private void 更多扩展_MouseLeave(object sender, MouseEventArgs e)
        {
            更多扩展.Background = new SolidColorBrush(Color.FromArgb(0, 0, 219, 18));
        }

        private void 官方模型下载_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://www.123114514.xyz/") { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }

        }

        private void 官方模型下载_MouseMove(object sender, MouseEventArgs e)
        {
            官方模型下载.Background = new SolidColorBrush(Color.FromArgb(255, 0, 219, 18));
        }

        private void 官方模型下载_MouseLeave(object sender, MouseEventArgs e)
        {
            官方模型下载.Background = new SolidColorBrush(Color.FromArgb(0, 0, 219, 18));
        }

        private void 清理环境_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 获取当前用户文件夹的路径
            string userFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            // 获取当前用户文件夹中是否有.cache文件夹
            string cacheFolderPath = System.IO.Path.Combine(userFolderPath, ".cache");
            if (Directory.Exists(cacheFolderPath))
            {
                // 将.cache文件夹移动到回收站
                FileSystem.DeleteDirectory(cacheFolderPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                SD信息.Text = ("CLIP/Pytorch已经清理");
            }
        }

        private void 清理环境_MouseMove(object sender, MouseEventArgs e)
        {
            本地版本信息.Text = ("删除Pytorch/clip等环境\n你将无法继续使用");
            清理环境.Background = new SolidColorBrush(Color.FromArgb(255, 255, 10, 10));
        }

        private void 清理环境_MouseLeave(object sender, MouseEventArgs e)
        {
            本地版本信息.Text = ("本地版本信息");
            清理环境.Background = new SolidColorBrush(Color.FromArgb(0, 255, 10, 10));
        }

        private void 直接在当前目录使用_Click(object sender, RoutedEventArgs e)
        {
            安装页面.Visibility = Visibility.Hidden;
            直接在当前目录使用.Visibility = Visibility.Hidden;
            为PC上的所有版本安装并在桌面显示快捷方式.Visibility = Visibility.Hidden;
        }


        private void 为PC上的所有版本安装并在桌面显示快捷方式_Click(object sender, RoutedEventArgs e)
        {

            //// 获取当前程序所在目录
            //string currentDir = System.AppDomain.CurrentDomain.BaseDirectory;
            //// 获取所有硬盘目录
            //string[] drives = Environment.GetLogicalDrives();
            //foreach (string drive in drives)
            //{
            //    // 搜索硬盘中的webui-user.bat文件
                
            //    string[] files = Directory.GetFiles(drive, "webui-user.bat", System.IO.SearchOption.AllDirectories);
            //    foreach (string file in files)
            //    {
            //        // 获取webui-user.bat所在目录
            //        string dir = System.IO.Path.GetDirectoryName(file);
            //        // 复制ADR5.exe到webui-user.bat所在目录
            //        File.Copy(currentDir + "ADR5.exe", dir + "\\ADR5.exe");
            //        // 在webui-user.bat所在目录创建1sta.txt
            //        File.Create(dir + "\\1sta.txt");
            //        // 在桌面创建ADR5.exe的快捷方式
            //        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //        File.Create(desktopPath + "\\ADR5.lnk");
            //    }




            }




        }
    }


    
    


    















