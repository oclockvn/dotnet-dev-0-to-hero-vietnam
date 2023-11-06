# Làm quen với ngôn ngữ C# | Trở thành .NET Developer - từ 0 tới hero | 04

Một điểm thú vị trong series [C# programming guide](https://learn.microsoft.com/vi-vn/dotnet/csharp/programming-guide/#:~:text=Most%20of%20this%20section%20assumes%20that%20you%20already%20know%20something%20about%20C%23%20and%20general%20programming%20concepts) là họ đã "giả sử" là bạn cần phải biết cơ bản về lập trình. Điều này có thể đơn giản nếu bạn đã biết lập trình hoặc 1 ngôn ngữ lập trình nào đó trước, tuy nhiên nếu bạn là 1 tờ giấy trắng thì đó là cả 1 quá trình dài. Trong series này mình đã nói là bạn không cần (kiến thức nền tảng) gì cả, vậy thì bạn sẽ bắt đầu như thế nào?

## Cách "mình" học lập trình

Học lập trình là 1 quá trình thú vị lặp đi lặp lại, đòi hỏi tự tìm tòi và tự trải nghiệm để rút ra kết luận cho bản thân. Nếu bạn đọc 1 tài liệu mà không làm theo, chỉnh sửa và theo dõi kết quả, bạn sẽ nhanh chóng quên đi những gì mình đọc được. Do đó bạn cần ghi nhớ các bước: 

**Đọc hiểu lý thuyết** ➡️ **Làm theo ví dụ mẫu** ➡️ **Mở rộng ví dụ mẫu** ➡️ **Chắt lọc kiến thức cho bản thân.**

## Bắt đầu

Nếu bạn tìm kiếm từ khóa "C# tutorial" trên google, sẽ có rất nhiều những bài viết, video, khóa học về nó, và bạn bắt đầu lựa chọn và đi hết từ lựa chọn này tới lựa chọn khác. Đó là 1 điều thường thấy ở những người mới học lập trình. Hãy chọn những series "ngắn" để dễ dàng follow, sau đó trong quá trình học thì tìm hiểu những thứ mình còn chưa hiểu.

[C# tutorial](https://www.w3schools.com/cs/index.php) của W3schools là 1 series rất phù hợp cho các bạn. Ở đây bạn sẽ biết được những thứ cơ bản nhất về C#, không dài dòng lan man. Và để nắm bắt được nó, đòi hỏi bạn phải tìm hiểu và thực hành nhiều hơn.

Vậy thì cách học của mình sẽ là: follow theo series [C# tutorial](https://www.w3schools.com/cs/index.php), sau đó hỏi google hoặc [Bard (Google AI)](https://bard.google.com/) để biết thêm chi tiết.

**Và phần này mình cũng sẽ để các bạn tự học.**

## Kết quả cần đạt

Sau khi học xong tutorial ở trên - bỏ qua phần OOP - (dự kiến khoảng 2 ngày) thì dưới đây là những gì bạn cần đạt được:

- Biết về các kiểu dữ liệu cơ sở
  - `int,long,float,double,decimal` để lưu số (number).
  - `bool` để lưu giá trị `true/false`.
  - `char` cho **1** ký tự, ví dụ: `'a'`, `'b'`, `'c'`, `'1'`, `'2'`, `'3'`, `'/'`, `'?'`, ...
  - `string` cho **nhiều** ký tự (hay còn gọi là chuỗi), ví dụ: `"my name"`, `"0123456789"`.
  - các kiểu dữ liệu khác.
- Biết cách khai báo biến và hiểu phạm vi của biến. Ví dụ:
  ```cs
  static void Main()
  {
    int i; // tạo biến có tên là "i" với kiểu dữ liệu là "int" và không gán giá trị.
    i = 5; // gán giá trị

    int j = 10; // tạo biến và đồng thời gán giá trị

    bool ok = true; // tạo biến bool và gán giá trị là true
    bool correct = 2 > 1; // tạo biến bool có giá trị là "kết quả" của phép so sánh "2 > 1" -> true

    // giả sử đã có hàm IsEvenNumber trả về true nếu số truyền vào là số chẵn
    bool isValid = IsEvenNumber(2); // tạo biến bool có giá trị là kết quả của method "IsEvenNumber(2)"
  }
  ```

  Phạm vi biến:
  ```cs
  class Program
  {
    static int count = 1; // biến toàn cục, có khả năng sử dụng ở "mọi nơi" trong class Program (phía trong dấu {})

    static void Main()
    {
      int total = 2; // biến cục bộ, chỉ có khả năng sử dụng phía trong hàm Main (trong dầu {})
    }
  }
  ```
- Biết các phép toán cơ bản với dữ liệu. Ví dụ:
  ```cs
  var sum = 1 + 2; // số thì có cộng trừ nhân chia
  var s = "Hello " + "world"; // chuỗi cũng cộng lại được (ghép chuỗi)
  Console.WriteLine(s.Length); // lấy số lượng phần tử => "Hello world".Length => 11
  Console.WriteLine(s[1] + ""); // lấy phần tử ở vị trí số 1 => "e"
  ```

- Biết cách chuyển đổi giữa các kiểu dữ liệu và hiểu khi nào có thể chuyển đổi được. Ví dụ
  ```cs
  // Hay gặp nhất là chuyển đổi từ số qua chuỗi và ngược lại.
  int number = 1;
  string s1 = number.ToString();
  string s2 = number + ""; // vẫn được, cộng số với chuỗi thì ra chuỗi

  string s = "1";
  int n = int.Parse(s); // n = 1
  ```
- Biết cách ngăn chặn lỗi (Exception) khi chuyển đổi. Ví dụ:
  ```cs
  string s = "2";
  int n = int.Parse(2); // ✅ n = 1

  string s2 = "a";
  int n2 = int.Parse(s2); // 🚫 exception => dùng int.TryParse

  bool success = int.TryParse(s2, out var n3); // success = false, n3 = 0 (default value), no exception
  ```
- Hiểu về câu điều kiện `if else`, `switch case`
  ```cs
  var isWeekend = false;
  if (isWeekend) // condition là biến bool
  { }

  if (2 > 1) // // condition là 1 expression => true
  { }

  if (IsEvenNumber(2)) // condition là method return true/false
  { }

  if (2 > 1 && IsEvenNumber(2)) // kết hợp điều kiện
  {}
  ```
- Hiểu về vòng lặp for/foreach
  ```cs
  // in từ 1 tới 10
  for (var i = 1; i <= 10; i++)
  {
    Console.WriteLine(i);
  }

  // tổng từ 1 tới 10
  var sum = 0;
  for (var i = 1; i <= 10; i++)
  {
    sum += i;
  }
  // sum = 55

  // tương tự với foreach

  ```

- Hiểu về vòng lặp while/do..while
  ```cs
  // in từ 1 tới 10
  int i = 1;
  while (i <= 10)
  {
    Console.WriteLine(i);
    i++;
  }

  // nhập đến khi lấy được số
  bool valid = false;
  while (!valid) // khi nào valid != true (hoặc == false) thì vẫn cứ lặp (có nghĩa là nếu valid == true thì dừng)
  {
    Console.Write("Enter number: ");
    valid = int.TryParse(Console.ReadLine(), out var number);
  }

  // lặp đến khi random ra số 2
  int i;
  int count = 0;
  do
  {
    count++;
    i = Random.Shared.Next(1, 5);
  } while (i != 2); // khi nào số i khác 2 thì vẫn cứ lặp (có nghĩa là nếu i == 2 thì dừng)

  Console.WriteLine($"Got 2 after {count} times");
  ```
- Biết cách tạo hàm, truyền tham số và trả về giá trị
  ```cs
  void Print() // hàm không nhận tham số và không trả về giá trị (hoặc có thể nói là trả về void)
  {
    Console.WriteLine("I'm here");
    return; // có thể dùng return
    Console.ReadLine(); // dòng này sẽ không chạy vì đã return (thoát) ở trên
  }

  void Print(string s) // hàm nhận 1 tham số kiểu string và không trả về
  {
    // 
  }

  int Sum(int a, int b) // hàm nhận 2 tham số và trả về kiểu int
  {
    int s = a + b;
    return s;
  }

  int Sum2(int a, int b)
  {
    return a + b; // viết gọn lại hàm Sum
  }

  int Sum3(int a, int b) => a + b; // gọn lại 2 hàm trên (không cần từ khóa return)
  ```

> Nhớ [snippets](https://learn.microsoft.com/en-us/visualstudio/ide/visual-csharp-code-snippets?view=vs-2022) sẽ giúp bạn gõ code nhanh hơn rất nhiều. Ví dụ chỉ cần gõ "for" và tab 2 lần, VS sẽ tạo 1 vòng lặp cho bạn.

## Bài tập

Với những kiến thức ở trên, hãy áp dụng vào các bài tập dưới đây.

> Fork repo này về và tạo 1 solution src, mỗi bài tạo 1 project tương ứng, ví dụ Ex01 cho bài số 1, Ex02 cho bài số 2.

### I. Nhập xuất và kiểu dữ liệu cơ bản

**1. Viết chương trình nhập vào tên và xuất ra "Hello, " [tên]**
  - sử dụng `Console.WriteLine()` để xuất và `Console.ReadLine()` để đọc

**2. Viết chương trình nhập vào 1 số và xuất ra bình phương của số đó**
  - đổi từ chuỗi sang số dùng `int.Parse("string")`
  - dùng `Math.Pow` để lấy bình phương
  
**3. Viết chương trình nhập vào 2 số, tính tổng 2 số đó**
  - dùng `int.Parse` để đổi từ chuỗi sang số và cộng 2 số lại
  
**4. Viết chương trình nhập vào 1 ký tự bất kỳ, in ra "Bạn đã nhập số" nếu ký tự đó là số, "Bạn đã nhập chuỗi" nếu ký tự không phải là số**
  - dùng `int.TryParse` để kiểm tra 1 chuỗi có phải là số hay không. 

**5. Viết chương trình nhập vào năm sinh, in ra số tuổi**
  - Tuổi = năm hiện tại - năm sinh  
  - Ngày hiện tại = `DateTime.Now`
   
### II. Câu điều kiện if else, for/foreach, while/do..while

**6. Viết chương trình nhập vào 1 ký tự bất kỳ, lặp lại đến khi nào người dùng nhập vào 1 số bằng 2 cách:**
  - sử dụng `while`
  - sử dụng `do..while`
  
**7. Viết chương trình nhập vào 1 số từ 2 tới 8, xuất ra "Monday" nếu số nhập vào là 2, "Tuesday" nếu số 3, ...**
  - Lặp lại cho tới khi nhập đúng số từ 2 tới 8 (ví dụ nếu người dùng nhập 0 thì báo nhập lại)
  - Sử dụng `if else` để xuất kết quả
  
**8. Tương tự như bài 7 nhưng sử dụng switch case**

**9. Tương tự bài 7 nhưng sử dụng pattern matching**

```cs
  var day = switch input
  {
    2 => "Monday",
    3 => "Tuesday",
    ...
  }
```

**10. Viết chương trình nhập vào 1 số, tính tổng các số liên tiếp từ 0.**
  - Ví dụ nhập vào 5 => xuất ra tổng 1 + 2 + 3 + 4 + 5
  - Lặp lại bước nhập số nếu người dùng nhập ký tự không phải là số

