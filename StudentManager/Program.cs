namespace StudentManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            // 文件操作窗口
            //Application.Run(new FrmFiles());
            // 对象保存操作
            Application.Run(new FrmObjectSave());
        }
    }
}