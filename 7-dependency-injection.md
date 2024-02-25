# Chap 07 Dependency Injection | Trở thành .NET Developer - từ 0 tới hero

> Series .net dev 02hero là 1 series đặc biệt được mình viết ra nhắm mục đích training cá nhân, các nội dung trong series này đều hoàn toàn có thể được tìm thấy rất nhiều trên internet, lý do mình viết lại những thứ có thể được tìm thấy ở internet là bởi mục đích không dành cho người có kiến thức nền tảng, và đồng thời cũng muốn cách diễn đạt theo lời văn của mình. Đây cũng là 1 bài viết đặc biệt vì nó thuộc về phần nâng cao, nhưng do tính chất training nên mình viết nó trước. Những ai chưa hiểu có thể bỏ qua hoặc xem lại bài này sau.

### Hiểu về ý tưởng của Dependency Injection (DI)

Kiến thức cơ bản về DI trong .NET (C#) có thể được tìm thấy ở đây: [.NET dependency injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection), tuy nhiên như đã đề cập ở trên, bạn sẽ có đôi chút mơ hồ nếu bạn không đủ kiến thức nền tảng (xuất phát không phải IT-based), do đó mình sẽ giải thích theo cách mình nghĩ là ai cũng sẽ dễ hiểu hơn.

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

có thể thấy để xây dựng 1 chiếc oto hoàn chỉnh, nhà máy phụ thuộc vào rất nhiều những manufacture khác. Ta nói nhà máy sản xuất AAA bị "phụ thuộc" vào manufacture SSS, CCC; hay nói cách khác,
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
      MainFrame = frame,
      MainEngine = engine
    };
  }
} 
```

ở ví dụ trên, `frameFactory` và `engineFactory` là 2 dependencies của class `CarFactory`. Ở đây mình đang "giả sử" là `frameFactory` và `engineFactory` đã được khởi tạo ở trước đó.

Bình thường thì dependencies có thể được tạo ra ở bất cứ đâu bằng constructor của nó, ví dụ dưới đây là 2 private fields như sau:

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

### (Dependency) Injection

Thêm 1 ví dụ thực tế hơn để dễ thấy tác dụng và ý nghĩa của dependency, và chuyển đổi từ self-managed dependency sang injected dependency.

```cs
public class OrderService
{
    public void PlaceOrder(Order order)
    {
        // 1. log the order

        // 2. save the order to the database

        // 3. send email to customer
    }
}
```

với các bước trong method `PlaceOrder`, mình sẽ dùng các services khác (dependency) để thực hiện, ví dụ:

```cs
// 1. log the order
logger.LogInformation("Placing order: " + order.ToString());
```

để gửi email, sử dụng email service:

```cs
// 3. send email to customer
emailService.Send(order.CustomerEmail, "Order details #123...");
```

có thể thấy `logger` và `emailService` là 2 dependency của `orderService`, bình thường 2 services này sẽ được tạo bởi constructor như sau (mã giả):

```cs
public class OrderService
{
    private readonly ILogger<OrderService> logger = new Logger();
    private readonly EmailService emailService = new();

    public void PlaceOrder(Order order)
    {
        ...
    }
}
```

thực tế việc khởi tạo instance cho 2 services này sẽ phức tạp hơn, cụ thể như sau:

Để tạo logger: https://learn.microsoft.com/en-us/dotnet/core/extensions/logging?tabs=command-line#get-started

```cs
using Microsoft.Extensions.Logging;

using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
ILogger logger = factory.CreateLogger("Program");
logger.LogInformation("Hello World! Logging is {Description}.", "fun");
```

để tạo `EmailService`, giả sử mình dùng [SendGrid](https://sendgrid.com/en-us) để gửi email (sendgrid client là dependency của EmailService):

```cs
var apiKey = "your-sendgrid-api-key";
var client = new SendGridClient(apiKey);
var emailService = new EmailService(client);
```

> Sample code: https://github.com/sendgrid/sendgrid-csharp

tổng hợp lại mình sẽ có:

```cs
public class OrderService
{
    private readonly ILogger<OrderService> logger;
    private readonly EmailService emailService;

    public OrderService()
    {
        // create logger
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        logger = factory.CreateLogger<OrderService>("Program");

        // create email service
        var apiKey = "your-sendgrid-api-key";
        var client = new SendGridClient(apiKey);
        emailService = new EmailService(client);
    }

    public void PlaceOrder(Order order)
    {
        ...
    }
}
```

tới đây thì chắc đã đủ để thấy được chuyện "tự" quản lý các dependency nó phức tạp ra sao, đó là chưa kể các vấn đề về maintenance, testing, ... rất khó thực hiện với cách như hiện tại.

**Lady and Gentlemen**, xin giới thiệu kỹ thuật dependency injection, chương trình được viết lại như sau:

```cs
public class OrderService
{
    private readonly ILogger<OrderService> logger;
    private readonly EmailService emailService;

    public OrderService(ILogger<OrderService> logger, EmailService emailService)
    {
        this.logger = logger;
        this.emailService = emailService;
    }

    public void PlaceOrder(Order order)
    {
        ...
    }
}
```

nó đã đơn giản hơn rất nhiều. Tất nhiên không phải cứ làm như trên là xong (sẽ chưa chạy được đâu), tuy nhiên bạn có thể hình dung ra chuyện "dependency" là gì, và "injection" là gì rồi, bây giờ mình sẽ kết hợp 2 cái đó lại.

### Dependency Injection

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/cc49173c-968b-47e6-81b1-5acced839b69)

> In software engineering, dependency injection is a programming technique in which an object or function receives other objects or functions that it requires, as opposed to creating them internally. Dependency injection aims to separate the concerns of constructing objects and using them, leading to loosely coupled programs...
> --https://en.wikipedia.org/wiki/Dependency_injection

hay nói 1 cách dễ hiểu hơn:

> [!IMPORTANT]
> Dependency injection là 1 kỹ thuật, trong đó 1 đối tượng không tự quản lý các dependency của nó mà được truyền vào từ bên ngoài.

Các thành phần trong DI:

- Services: chính là các class/interface trong C#. Trong ngữ cảnh DI, các đối tượng (class/interface) được xem như là các services.
- `ServiceCollection`: là class chứa các services đã được đăng ký. Bạn cần "đăng ký" (thêm) tất cả các services vào `ServiceCollection` trước khi sử dụng.
- `ServiceProvider`: là class có nhiệm vụ "cung cấp" các dependency cho 1 service khác.

Lấy ví dụ chương trình sau:

```cs
namespace di_sample;
public static class Program
{
    public static void Main(string[] args)
    {
        IEmailService emailService = new EmailService();
        IOrderService orderService = new OrderService(emailService);

        orderService.PlaceOrder(new Order {});
    }
}

public class Order { /*..*/ }

public interface IOrderService { void PlaceOrder(Order order); }
public class OrderService : IOrderService
{
    private readonly IEmailService emailService;

    public OrderService(IEmailService emailService)
    {
        this.emailService = emailService;
    }

    public void PlaceOrder(Order order)
    {
        // Place order
        emailService.SendEmail(order.CustomerEmail!, "Order Placed", "Your order has been placed");
    }
}

public interface IEmailService { void SendEmail(string to, string subject, string body); }
public class EmailService : IEmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        // Send email
        System.Console.WriteLine($"Email sent to {to} with subject {subject} and body {body}");
    }
}
```

Kết quả chương trình:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/8f89b446-bbb1-4091-8df4-6e86a4026f51)

#### 1. Cài đặt

> [!NOTE]
> Việc cài đặt chỉ cần làm đối với những project không support sẵn DI như console app, windows form, wpf, ... Ở những project đã support sẵn (web app, blazor...) thì chỉ cần sử dụng.

Cần phải cài đặt package `Microsoft.Extensions.DependencyInjection`, lưu ý là ở mỗi thời điểm thì version có thể sẽ khác nhau:

```
dotnet add package Microsoft.Extensions.DependencyInjection --version 8.0.0
```

#### 2. Sử dụng

Đầu tiên, tạo `ServiceCollection` để chứa tất cả các services:

```cs
using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();
```

tiếp, đăng ký tất cả các services liên quan, bao gồm dependencies và các services sử dụng dependency đó:

```cs
services.AddTransient<IEmailService, EmailService>(); // thêm EmailService vào ServiceCollection
services.AddTransient<IOrderService, OrderService>(); // thêm OrderService vào ServiceCollection
```

kế tiếp, tạo `ServiceProvider` để có thể lấy bất cứ services nào từ collection:

```cs
IServiceProvider serviceProvider = services.BuildServiceProvider();
```

cuối cùng, lấy service cần sử dụng ra bằng `ServiceProvider`:

```cs
IOrderService orderService = serviceProvider.GetRequiredService<IOrderService>();
```

Xem [commit](https://github.com/oclockvn/dependency-injection-sample/commit/fa6c7570a6b648b362cfc575b1b5e95d4cdd7f24) để thấy sự thay đổi.

#### 3. Quá trình hoạt động

Để hiểu thêm về cách DI hoạt động, hay tiếp tục chỉnh sửa chương trình 1 chút. Mình sẽ tạo thêm 1 service nữa và inject nó vào `OrderService` (xem [commit](https://github.com/oclockvn/dependency-injection-sample/commit/bdbdc065dfedcc2739d734b2cf1b92099b671fd7)):

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/e3e37c13-c41d-4add-8f7e-b5eae70d9869)

Thử chạy lại chương trình, bạn sẽ nhận được exception như sau:

> Unhandled exception. System.InvalidOperationException: Unable to resolve service for type 'di_sample.IEventService' while attempting to activate 'di_sample.OrderService'.

Đây là exception bạn sẽ nhận được nếu như có 1 trong các dependency của OrderService chưa được "đăng ký". Để xử lý lỗi này, chỉ cần thêm event service vào collection:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/028a8e4a-d3dd-40ff-9b97-bf6d1c4588e1)

Vậy chuyện gì đã xảy ra? Bạn có thể hình dung như sau:

1. Khi bạn gọi tới `serviceProvider.GetRequiredService<IOrderService>()`.
2. SP phát hiện class `OrderService` là class kế thừa `IOrderService` đã được khai báo thông qua `services.AddTransient<IOrderService, OrderService>();`.
3. SP kiểm tra xem `OrderService` có những dependencies nào. SP phát hiện ra 2 dependencies là `IEmailService` và `IEventService`
4. SP lấy `IEmailService` từ `ServiceCollection`. (Thực tế lúc này SP lại tiếp tục kiểm tra xem EmailService có dependencies hay không, quá trình này lặp lại cho tới khi tất cả các dependencies của nó đã được khởi tạo thành công). vì đã đăng ký EmailService nên ServiceCollection trả về instance của EmailService cho SP.
5. SP lấy `IEventService` từ collection. Collection hét lớn: "Chưa đăng ký mà đòi lấy, có cái \*beep\* mà tao đưa". Thế là có exception.

### Tạm kết

Ở trên chỉ là 1 phần nhỏ trong kỹ thuật DI, từ đó hy vọng bạn sẽ dễ dàng tiếp cận được các document official của MS như:

- [.NET dependency injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)
- [Tutorial: Use dependency injection in .NET](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage)
- [Dependency injection guidelines](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-guidelines)

Những khía cạnh bạn cần tìm hiểu thêm như:

- Service lifetime: scope của 1 service
- Services resolver: các cách resolve aka tạo instance
- Circular dependencies: 2 service bị phụ thuộc lẫn nhau
- Injection type: không chỉ có constructor injection mà còn có các loại inject khác nữa

Code của bài viết: https://github.com/oclockvn/dependency-injection-sample

Have fun!
