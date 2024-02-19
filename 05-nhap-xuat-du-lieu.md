# Nhập xuất dữ liệu | Trở thành .NET Developer - từ 0 tới hero | 04

### Mục tiêu bài học
- [x] Biết cách xuất dữ liệu ra màn hình dòng lệnh (write to console)
- [x] Biết cách lấy thông tin từ dòng lệnh (read from console)
- [x] Biết 1 số toán tử cơ bản với chuỗi string
- [x] Biết cách chuyển đổi kiểu dữ liệu (string <-> int)

### Tạo project

Tạo 1 console project, visual studio (VS) sẽ tạo 1 console app với 1 số dòng code sẵn:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/f077637d-255f-43a6-9677-ec502787b0ef)

Chạy chương trình <kbd>F5</kbd>, bạn sẽ thấy "Hello World" xuất hiện ở console:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/67827586-cb37-4a01-9dcd-6fcccdf283fc)

### 1. Xuất ra console

Xuất ra console là việc bạn muốn hiển thị thông tin ra console. Sửa đoạn code có sẵn thành như sau:

```cs
static void Main(string[] args)
{
    Console.WriteLine("I am Quang");
}
```

Yay! bạn đã in ra console thành công.

#### Giải thích:
- hàm `Console.WriteLine` nhận vào 1 chuỗi string và trả về void, được dùng để xuất thông tin ra console

> [!TIP]
> Rê chuột lên tên hàm để hiển thị mô tả của hàm, các loại tham số truyền vào hàm và kết quả trả về

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/b36722a0-b655-431f-81a8-cc0ba0758e94)

#### Mở rộng
Vậy nếu muốn in ra nhiều dòng thì sao? thì gọi hàm nhiều lần chứ sao :)

```cs
static void Main(string[] args)
{
    Console.WriteLine("I am Quang");
    Console.WriteLine("I love swimming");
}
```

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/555d6615-61ce-45b8-8f98-bdacb998faaf)

Ngoài ra, với tính chất của string là có thể xuống dòng, mình cũng có thể sử dụng 1 lần write với nội dung như sau:

```cs
static void Main(string[] args)
{
    Console.WriteLine("I am Quang\r\nI love swimming");
}
```

Chuỗi `"\r\n"` là ký tự xuống dòng, do đó bạn được kết quả như mong đợi.

> [!TIP]
> Bạn nên sử dụng `Environment.NewLine` để đạt kết quả đúng khi chạy trên cả Windows và Linux do ở Linux thì xuống dòng chỉ là `"\n"`

refactor đoạn code trên:

```cs
static void Main(string[] args)
{
    Console.WriteLine("I am Quang" + Environment.NewLine + "I love swimming"); // cộng chuỗi
}
```

dĩ nhiên kết quả vẫn như mong đợi:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/112c4191-e161-47d7-9c12-349e8747551e)

Ở trên mình cũng đã thực hiện 1 toán tử khác của string là cộng (nỗi) chuỗi (concatnate). Ví dụ:

```cs
var s1 = "A" + "B"; // -> "AB"
var s2 = "A " + "B"; // -> "A B"
var s3 = "A" + "B" + "C"; // -> "ABC"
```

> [!TIP]
> Sử dụng nút lên/xuống để xem các "biến thể" (overloading) khác của hàm `Console.WriteLine`
![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/33c60ad8-6870-442c-abac-06ede1ac1cf7)


### 2. Đọc từ console

Đọc từ console là việc bạn nhập liệu vào dòng lệnh, sau đó đọc giá trị đó ra chương trình.

```cs
/// Reads the next line of characters from the standard input stream.
string Console.ReadLine();
```

Khi gọi tới hàm này, chương trình sẽ dừng lại cho đến khi bạn nhập vào gì đó và bấm Enter.

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/a50e5275-ecc6-495f-a5aa-1a9c8aade9a9)

kết quả:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/f4fbd844-1d97-4b6b-b33d-ac916b9e2ca3)

### 3. Chuyển đổi kiểu dữ liệu

> Chuyển đổi kiểu dữ liệu (data converting) là cách đổi từ kiểu dữ liệu này thành kiểu dữ liệu khác. Việc chuyển đổi là cần thiết để thực hiện các toán tử tương ứng với kiểu dữ liệu đó.

Để đổi từ string sang int, sử dụng hàm `int.Parse(string)`. Ví dụ:

```cs
string ageString = "18";
int ageNumber = int.Parse(ageString); // -> 18
```

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/363a46bd-c515-4ad5-b556-313bfe154b73)

### Thực hành

1. Xuất ra console: Thực hành việc sử dụng hàm Console.WriteLine để in ra màn hình console các thông điệp.

2. Xuất nhiều dòng: Tạo một chương trình in ra nhiều dòng thông điệp bằng cách sử dụng nhiều lần hàm Console.WriteLine hoặc sử dụng ký tự xuống dòng "\r\n" hoặc Environment.NewLine.

3. Đọc từ console: Viết chương trình để đọc dữ liệu nhập vào từ console bằng cách sử dụng hàm Console.ReadLine().

4. Chuyển đổi kiểu dữ liệu từ string sang int: Thực hiện việc chuyển đổi kiểu dữ liệu từ string sang int bằng cách sử dụng phương thức int.Parse().

5. Chuyển đổi kiểu dữ liệu từ string sang double: Tương tự như bài tập trên, nhưng lần này là chuyển đổi từ string sang double bằng cách sử dụng phương thức double.Parse().

6. Xử lý ngoại lệ: Xử lý trường hợp người dùng nhập dữ liệu không hợp lệ bằng cách sử dụng cấu trúc try-catch khi thực hiện chuyển đổi kiểu dữ liệu.

7. Tính toán với dữ liệu nhập từ console: Yêu cầu người dùng nhập vào hai số và thực hiện một phép tính cơ bản như cộng, trừ, nhân, chia, sau đó in kết quả ra màn hình.

8. Tạo chương trình đơn giản quản lý thông tin người dùng: Yêu cầu người dùng nhập thông tin về tên, tuổi, địa chỉ và sau đó in thông tin này ra màn hình.

9. Kiểm tra điều kiện với dữ liệu nhập từ console: Yêu cầu người dùng nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn hay số lẻ không, sau đó in ra thông báo tương ứng.

10. Tạo ứng dụng nhập/xuất thông tin danh bạ: Xây dựng một ứng dụng đơn giản cho phép người dùng nhập thông tin liên hệ (tên, số điện thoại, email) và sau đó hiển thị danh sách thông tin này ra màn hình.

**Solution tham khảo**: https://github.com/oclockvn/02hero-chap-05-sample-code
