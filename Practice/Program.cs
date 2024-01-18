using System.Linq;
namespace Practice {
    public class Program {
        // 泛型方法
        // 添加泛型约束 where T : (限制类型)
        // 该语法表示T类型必须继承自冒号后标识的类型。
        static string GetTypeName<T>() {
            var type = typeof(T);
            return type.Name;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(GetTypeName<int>());
            // 集合
            List<int> list = new List<int>(); 
            list.Where(x => list.Contains(x));
        }
    }
}