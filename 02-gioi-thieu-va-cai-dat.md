# Giới thiệu tổng quan | Trở thành .NET Developer - từ 0 tới hero | 02

### Về ngôn ngữ C#

C# (đọc là See-Sharp | "si sáp") là ngôn ngữ hiện đại, hướng đối tượng và "type-safe" (kiểu an toàn*), được phát triển bởi Microsoft...

> (*) Sẽ có chỗ (và nhiều chỗ) mình giữ nguyên văn từ tiếng Anh vì nó sẽ diễn tả tốt hơn ý nghĩa của từ đó, tuy nhiên mình cũng sẽ "dịch" sang tiếng Việt ở trong ngoặc cho những ai chưa biết về từ đó.

Khoan khoan, dừng lại chừng 2s. Nếu tiếp tục viết lại những thứ đã có thì các bạn nên vào [link chính chủ đây](https://learn.microsoft.com/vi-vn/dotnet/csharp/tour-of-csharp/) đọc cho đầy đủ. Trong series này mình sẽ cố gắng giải thích những gì mà mình nghĩ là nó đơn giản dễ hiểu hơn.

### Tại sao mình (mình là chính các bạn đó) lại chọn C#?

Nếu bạn đang tự hỏi câu này thì bạn có thể rơi vào các trường hợp sau:
- Bạn đang tìm 1 cái gì đó mới để học và đang so sánh các ngôn ngữ để xem nên học cái nào
- Bạn cũng đang tìm nhưng được ai đó giới thiệu cho C# và đang muốn xem thêm về nó
- Đa phần là 2 trường hợp trên, nếu bạn đã làm 1 thời gian thì có thể trường dạy bạn về C# trước nên bạn theo tới giờ :), đó cũng đa phần là lý do chính của bạn.

Để trả lời cho câu hỏi này thì mình nghĩ không có câu trả lời nào là thích đáng cả. Mọi ngôn ngữ đều sinh ra để làm sản phẩm nào đó, cho nên bạn chọn ngôn ngữ nào cũng được, cái nào cũng có cái hay và không hay riêng. Nếu buộc phải trả lời thì mình sẽ nói đại là:
- Xưa mình học cái này nên mình làm tới bây giờ.
- C# có thể làm được nhiều sản phẩm ở nhiều nền tảng (platform) khác nhau, từ web (.NET Core), mobile (Xamarin -> MAUI), Desktop (WinForms/WPF) tới vô vàng thứ khác nữa ở [đây](https://learn.microsoft.com/en-us/dotnet/#create-your-application)
- Ban đầu thì có vẻ khó học, nhưng vì tính chất là ngôn ngữ strongly-typed (không phải là "gõ mạnh" đâu nhen, strongly-typed là tính chất của ngôn ngữ C#, một khi khai báo kiểu dữ liệu thì không thay đổi được nữa) và có IDE (integrated development environment - môi trường phát triển phần mềm tích hợp) cực kỳ mạnh mẽ là Visual Studio nên việc tiếp cận ngôn ngữ rất dễ dàng.

Phần giới thiệu chỉ cần tới đây thôi.

### .NET Framework và .NET Core, giờ chỉ còn là .NET

.NET Framework là phiên bản Windows Only (chỉ chạy trên Windows), trải qua các [versions](https://en.wikipedia.org/wiki/.NET_Framework_version_history) khác nhau cho tới v4.8 thì dừng lại, sau đó .NET Core được phát hành (2014), có thể chạy cross playforms (Windows, Mac và Linux). Kể từ sau .NET Core 3.1 thì chỉ còn gọi là .NET (.NET 5, 6, 7, 8). Do đó khi học và làm việc, 
các bạn phải chú ý version (phiên bản) mà mình đang sử dụng.

Đọc nhiều hơn ở [đây](https://learn.microsoft.com/en-us/dotnet/core/introduction#net-history)

### Cài đặt

Trong series này mình sẽ dùng .NET 7 (có thể là 8), do đó mình sẽ download .NET SDK 7: https://dotnet.microsoft.com/en-us/download (trang này sẽ hiển thị SDK [LTS](https://en.wikipedia.org/wiki/Long-term_support), nên có thể khi bạn mở ra thì nó đã là .NET version khác)

> [SDK](https://learn.microsoft.com/en-us/dotnet/core/introduction#tools) - software development kit - là bộ công cụ phát triển lập trình, trong đó bao gồm những thư viện (libraries/frameworks - những đoạn code được viết sẵn (builtin) để hỗ trợ lập trình), các công cụ, trình biên dịch... để giúp mình phát triển phần mềm.

Những công cụ mình sẽ sử dụng trong series:
- [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/): phiên bản miễn phí của Visual Studio (VS), bộ IDE mạnh mẽ cho mọi thứ khi làm việc với .NET
- [Visual Studio Code aka VSCode](https://code.visualstudio.com/): Code Editor có thể dùng để thay thế VS khi làm việc với 1 số loại dự án (đa phần là web)
- [Linqpad](https://www.linqpad.net/): không những dùng để truy vấn cơ sở dữ liệu, linqpad còn có rất nhiều [tính năng hay ho](https://oclockvn.github.io/2020/05/02/su-dung-linqpad-co-ban-va-nang-cao.html)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/): mình dùng thay thế cho MSSQL vì dễ setup
- nếu không xài docker thì bạn cần cài đặt Sql Express ([Free version](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)), nếu không muốn xài linqpad thì cài tiếp SQL Management Studio
- [Windows Terminal](https://github.com/microsoft/terminal): Terminal mới của MS, rất mạnh mẽ khi kết hợp với bash shell
- [Notepad++](https://notepad-plus-plus.org/downloads/): Text Editor hầu như dev nào cũng biết
- [Git](https://git-scm.com/download/): Version control (tự học nhé)

Và đăng ký tài khoản ở những website sau:
- Google (chắc ai cũng đã có)
- Github (site này nè)

Sau khi đã cài đặt các phần mềm ở trên, thử mở terminal và gõ:

```
dotnet --list-sdks
```

Nếu kết quả là danh sách những SDK bạn đã cài đặt thì chúc mừng, còn không thì thử google xem chuyện gì đã xảy ra nhen.

:white_check_mark: Excercies

- :black_square_button: Trình biên dịch (compiler) là gì?
- :black_square_button: Code của bạn được biên dịch và thực thi ra sao?