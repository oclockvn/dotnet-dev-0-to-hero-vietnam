# Chap 07 Dependency Injection | Trở thành .NET Developer - từ 0 tới hero

> Series .net dev 02hero là 1 series đặc biệt được mình viết ra nhắm mục đích training cá nhân, các nội dung trong series này đều hoàn toàn có thể được tìm thấy rất nhiều trên internet, lý do mình viết lại những thứ có thể được tìm thấy ở internet là bởi mục đích không dành cho người có kiến thức nền tảng, và đồng thời cũng muốn cách diễn đạt theo lời văn của mình. Đây cũng là 1 bài viết đặc biệt vì nó thuộc về phần nâng cao, nhưng do tính chất training nên mình viết nó trước. Những ai chưa hiểu có thể bỏ qua hoặc xem lại bài này sau.

### Hiểu về ý tưởng của Dependency Injection (DI)

Kiến thức cơ bản về DI trong .NET (C#) có thể được tìm thấy ở đây: [.NET dependency injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection), tuy nhiên như đã đề cập
ở trên, bạn sẽ có đôi chút mơ hồ nếu bạn không đủ kiến thức nền tảng (xuất phát không phải IT-based), do đó mình sẽ giải thích theo cách mình nghĩ là ai cũng sẽ dễ hiểu hơn.

Nếu mình hỏi chatGPT như thể là 1 đứa trẻ:
> Q: explain dependency injection in C# like I'm 5

Câu trả lời sẽ là:
> A: Alright, imagine you have a toolbox, and you need different tools to build things. Instead of keeping all the tools in your pocket, you have a magic box that gives you the exact tool you need whenever you ask for it. That magic box is like dependency injection.
> In C#, your code might need other pieces of code (like tools) to work properly. Instead of your code going out and grabbing those pieces itself, dependency injection gives your code a way to ask for what it needs, and something else (usually a framework or another part of your program) provides those pieces for you.
> So, it's like having a magic toolbox that gives your code the right pieces it needs to get the job done without your code having to worry about finding them itself.

Nếu mình là 1 junior developer thì sao?
> Q: explain about dependency injection for junior developer

Trả lời:
> Dependency Injection (DI) is a design pattern used in programming and software development. It's a way to implement Inversion of Control (IoC), which means the process of externalizing the management and configuration control of dependencies for a class or module.
>
> Here's a simple explanation:
> 
> Imagine you're building a car (let's call this Car class). This car needs an engine to run. Instead of creating the engine inside the car, you build it separately (let's call this Engine class) and then "inject" it into the car at the time of creation. This way, the Car class doesn't need to know how to build an Engine, it just needs to know that it can use one. This is the basic idea of Dependency Injection.
> 
> There are three types of dependency injection:
> 
> Constructor Injection: The dependencies are provided through a class constructor.
> Setter Injection: The client exposes a setter method that the injector uses to inject the dependency.
> Interface Injection: The dependency provides an injector method that will inject the dependency into any client passed to it. Clients must implement an interface that exposes a setter method that accepts the dependency.
> 
> Why use Dependency Injection?
> 
> Decoupling: DI helps in decoupling code. The objects do not need to look up their dependencies, and do not need to know the location or class of the dependencies.
> Ease of Testing: It's easier to test modules in isolation, by injecting mock dependencies into the module during the testing phase.
> Flexibility and Reusability: By decoupling the classes, the code becomes more flexible and reusable.
> Remember, the main idea behind Dependency Injection is that it allows your code to be decoupled, reusable, and easier to test.

Có thể bạn cũng hình dung ra "sơ sơ" rồi, nhưng thực tế áp dụng ra sao thì có thể bạn còn đang hoang mang lắm. Mình sẽ đi từng thành phần để hiểu hết về DI.

### 1. Dependency

> A dependency is an object that another object depends on.
> -- [.NET dependency injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection#:~:text=A%20dependency%20is%20an%20object%20that%20another%20object%20depends%20on.)

Bạn là nhà máy lắp ráp và sản xuất oto AAA. Tuy nhiên bạn không tự mình làm hết các bộ phận của chiếc xe mà thuê các bên gia công các thành phần sau đó lắp ráp chúng lại thành oto hoàn chỉnh.

Việc này được mô phỏng "vui" như sau:

```
sản xuất xe AAA
  1. khung sườn
    1.1. đặt hàng khung SSS
    1.2. lắp khung
  2. động cơ
    2.1. đặt hàng động cơ CCC
    2.2. lấy động cơ
  3. ...
  10. lắp ráp các bộ phận
hoàn thành xe
```

có thể thấy để xây dựng 1 chiếc oto hoàn chỉnh, nhà máy phụ thuộc vào rất nhiều những manufacture khác. Ta nói nhà máy sản xuất AAA bị "phụ thuộc" vào manufacture SSS, CCC, hay nói cách khác,
SSS, CCC là những thành phần phụ thuộc (dependency) của AAA.

Nếu mô phỏng quá trình này bằng C# ta sẽ có:

```cs
// Frame, Engine là những class đại diện cho khung sườn và động cơ, được giả sử là đã có sẵn
public class Car
{
  public Frame MainFrame;
  public Engine MainEngine;
}

public class FrameFactory {
  public Frame MakeFrame();
}

public class EngineFactory {
  public Engine MakeEngine();
}

public class CarFactory {
  public Car MakeCar() {
    var frame = frameFactory.MakeFrame(); // create frame
    var engine = engineFactory.MakeEngine(); // create engine

    // make the car
    return new Car
    {
      Frame = frame,
      Engine = engine
    };
  }
} 
```

ở ví dụ trên, `frameFactory` và `engineFactory` là 2 dependencies của class `CarFactory`. Ở đây mình đang "giả sử" là `frameFactory` và `engineFactory` đã được khởi tạo ở trước đó.

Bình thường thì dependencies có thể được tạo ra ở bất cứ đâu bằng constructor của nó, ví dụ như sau:

```cs
public class CarFactory
{
  // initialize dependencies
  private FrameFactory frameFactory = new FrameFactory();
  private EngineFactory engineFactory = new EngineFactory();

  public Car MakeCar()
  {
    var frame = frameFactory.MakeFrame();
    var engine = engineFactory.MakeEngine();

    return new Car {...};
  }
} 
```



