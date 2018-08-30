# Algorithms-4th-Edition

算法（第4版）习题题解 C# 版

当前已经完成到 2.4。

可以在这个网站搜索题解：https://ikesnowy.github.io/Alg4-Solutions/

## 目录

- [1.基础 Fundamental](https://github.com/ikesnowy/Algorithms-4th-Edition-in-Csharp/tree/master/1%20Fundamental)
  - [1.1 基础编程模型 Programming Model](https://github.com/ikesnowy/Algorithms-4th-Edition-in-Csharp/tree/master/1%20Fundamental/1.1)
  - [1.2 数据抽象 Data Abstraction](https://github.com/ikesnowy/Algorithms-4th-Edition-in-Csharp/tree/master/1%20Fundamental/1.2)
  - [1.3 背包、队列和栈 Bags, Queues, and Stacks](https://github.com/ikesnowy/Algorithms-4th-Edition-in-Csharp/tree/master/1%20Fundamental/1.3)
  - [1.4 算法分析 Analysis of Algorithms](https://github.com/ikesnowy/Algorithms-4th-Edition-in-Csharp/tree/master/1%20Fundamental/1.4)
  - [1.5 案例研究：union-find 算法 CaseStudy: UnionFind](https://github.com/ikesnowy/Algorithms-4th-Edition-in-Csharp/tree/master/1%20Fundamental/1.5)

- [2.排序 Sorting](https://github.com/ikesnowy/Algorithms-4th-Edition-in-Csharp/tree/master/2%20Sorting)
  - [2.1 初级排序算法 Elementary Sorts](https://github.com/ikesnowy/Algorithms-4th-Edition-in-Csharp/tree/master/2%20Sorting/2.1)
  - [2.2 归并排序 Mergesort](https://github.com/ikesnowy/Algorithms-4th-Edition-in-Csharp/tree/master/2%20Sorting/2.2)
  - [2.3 快速排序 Quicksort](https://github.com/ikesnowy/Algorithms-4th-Edition-in-Csharp/tree/master/2%20Sorting/2.3)
  - [2.4 优先队列 Priority Queues](https://github.com/ikesnowy/Algorithms-4th-Edition-in-Csharp/tree/master/2%20Sorting/2.4)


## 使用方法 & 测试环境

### 使用方法：  

1. 下载整个解决方案（可能会非常大），打开 Algorithms 4th Edition.sln 文件，右击需要的项目--设为启动项目，运行。 
2. 下载对应章节文件夹（例如文件夹 1.3），打开包含在其中的解决方案（例如 1.3.sln）文件，右击需要的项目--设为启动项目，运行。
3. 下载你需要的项目文件和库文件（库文件一般位于相应章节文件夹下），添加到 Visual Studio 中运行。 
   例如，下载了 1.3.26 和 Generics 文件夹。打开 1.3.26 文件夹下的项目文件之后（后缀为 .csproj 的文件），Visual Studio 会自动生成一个解决方案。 
   之后点击左上角 “文件”——“添加”——“现有项目”，找到 Generics 文件夹下的项目文件并添加，之后就可以编译并运行 1.3.26 的程序了。 
4. 直接在 Github 上查看、复制源代码。 
5. 去 [我的博客](http://www.cnblogs.com/ikesnowy/) 上查看相关代码和解释。 

### 文件说明：

#### 控制台应用程序  

Program.cs 是程序的运行代码。 
需要实现的类会位于其他源文件中，例如实现有理数类的代码就会在同项目下的 Rational.cs 文件中。  

#### Windows 窗体应用程序

题目说明位于 Program.cs 文件中，绘图和逻辑部分代码可能在窗体文件，也可能在 Program.cs 中。  

### 开发环境： 

Visual Studio 2017 + .NET Framework 4.7  

## 代码规范

主要参照 [Framework Design Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/) 和 [C# 编程指南](https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/index) ，以及以下几条附加内容。

1. 单行注释（"//"）和注释内容之间必须有一个空格。中英文字符之间也需要有一个空格。例如：

   ```c#
   // 这是一行 C# 注释内容。
   ```

2. 类前的修饰符参照如下顺序排列，参照 [C# 语言规范](https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/language-specification/classes#class-declarations)。

   ```csharp
   new
   public/protected/internal/private
   abstract
   sealed
   static
   ```

3. 方法前的修饰符参照如下顺序排列。

   ```csharp
   new
   public/protected/internal/private
   static
   virtual
   sealed
   override
   abstract
   extern
   async
   ```

4. 字段前的修饰符按照如下顺序排列。

   ```csharp
   new
   public/protected/internal/private
   static
   readonly
   volatile
   ```

5. 属性前的修饰符按如下顺序排列。

   ```csharp
   new
   public/protected/internal/private
   static
   virtual
   sealed
   override
   abstract
   extern
   ```

   例子：

   ```csharp
   public abstract class BubbleSort : Sort
   {
     public static abstract void Sort (Comparable[] a);
     private static override void Show();
   }
   ```

## 相关资料  

官方 MOOC 课程： 

Part1 https://www.coursera.org/learn/algorithms-part1

Part2 https://www.coursera.org/learn/algorithms-part2

官方资料站 (English):

http://algs4.cs.princeton.edu/
