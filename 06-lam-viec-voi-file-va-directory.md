# Chap 06: Làm việc với File và Directory | Trở thành .NET Developer - từ 0 tới hero

### Mục tiêu bài học

- [x] Biết cách đọc và ghi text file (text, csv, json, ...)
- [x] Biết cách lấy danh sách file và directory trong 1 directory nào đó
- [x] Hiểu về đường dẫn (path) và biết 1 số thao tác với đường dẫn
- [ ] Xử lý file có dung lượng lớn sử dụng stream
- [ ] Làm quen với xử lý bất đồng bộ (Task)

> [!NOTE]
> Directory có thể hiểu là folder (thư mục), xem thêm để biết sự khác nhau về folder và directory ở đây: [What is the difference between a directory and a folder?](https://stackoverflow.com/questions/5078676/what-is-the-difference-between-a-directory-and-a-folder). Trong development mình thường xử dụng term "directory", trong ngữ cảnh sử dụng (Windows) mình thường xử dụng term "folder".

Tương tác với file (nói chung về file/directory) là những hành động thường xuyên được thực hiện khi viết ứng dụng .NET. .NET hỗ trợ việc tương tác với file rất đơn giản thông qua các class `File`, `Directory`, `Path`...

### Vấn đề 1: đọc và hiển thị 1 text file

**Yêu cầu:** đọc 1 file readme.txt nằm cùng folder với chương trình, sau đó hiển thị nội dung file ra console.

**Solution:**

```cs
namespace chap_06_file_and_directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var content = File.ReadAllText("readme.txt"); // read file content
            Console.WriteLine(content); // show to console
        }
    }
}
```

Chạy chương trình và bạn sẽ nhận được exception tương tự như sau:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/bc0809e3-7ed2-419b-9ed9-1b19b36fe37c)

Lý do là chương trình không tìm thấy file "readme.txt". Mặc định với đường dẫn tương đối thì chương trình sẽ giả sử file readme.txt nằm chung folder với chương trình.

**Solution:** tạo 1 file readme.txt nằm ở folder debug

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/825f2e96-1cab-4e4a-b121-64c9c99661c6)

Chạy lại chương trình:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/fff4eff2-8a0c-41d5-8f2d-71c651b22ce9)

### Vấn đề 2: đọc text file ở bất cứ đâu

**Yêu cầu:** đọc file ở vị trí bất kỳ và hiển thị ra console.

**Solution:** 

- Mở 1 file bất kỳ và copy file path:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/dba0742b-9d56-49db-9bf7-7fda02689634)

Path sẽ có giá trị như sau (đường dẫn tuyệt đối trên Windows):

```
"C:\Users\quangphan\Documents\Book1.csv"
```

**Coding:**

```cs
  // read from absolute path
  var content2 = File.ReadAllText(@"C:\Users\quangphan\Documents\Book1.csv");
  Console.WriteLine(content2);
```

**Kết quả:**

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/e6a7abe6-aa08-42de-bc05-75c0cc0b392e)

> [!TIP]
> sử dụng `@"..."` để giữ nguyên format của đường dẫn. Ngoài ra còn có thể dùng `\` để escape string

```cs
var content2 = File.ReadAllText(@"C:\Users\quangphan\Documents\Book1.csv"); // sử dụng @"..."
var content3 = File.ReadAllText("C:\\Users\\quangphan\\Documents\\Book1.csv"); // escape string "..\\..\\"
```

**💡Notes:** Tìm hiểu ý nghĩa của các hàm read khác:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/7673042b-0ea4-49be-a595-577c8f55dc45)

### Vấn đề 3: ghi ra file

**Yêu cầu**: nhập tên từ console sau đó ghi ra file name.txt

**Coding**:

```cs
static void Main(string[] args)
{
    // get name from console then write to file name.txt
    Console.WriteLine("Enter your name:");
    var name = Console.ReadLine();
    File.WriteAllText("name.txt", name);
}

```

**Kết quả:**

Bạn có đoán được file `name.txt` được tạo ra ở đâu không? chính là ở cùng thư mục với nơi chương trình chạy giống với lúc bạn đọc file readme.txt ở trên:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/58ebd171-9de9-410a-a871-3c8f00b2a574)

Vậy liệu ghi ra file với 1 đường dẫn bất kỳ nào đó có tương tự việc đọc file hay không? bạn thử đoán xem!

### Vấn đề 4: ghi ra file với đường dẫn tuyệt đối (hợp lệ) bất kỳ

**Yêu cầu**: nhập tên từ console sau đó ghi ra file với đường dẫn tuyệt đối bất kỳ.

Giả sử bạn có cấu trúc thư mục như sau:

```
.
└── home/
    ├── videos
    └── downloads
```

bạn đang có 1 string và muốn ghi ra đường dẫn `/home/downloads/new-folder/name.txt` (ngầm hiểu là đường dẫn, thực tế trên Windows thì nó phải là `C:\home\downloads\new-filter\new.txt`)

> [!NOTE]
> Trong Windows, đường dẫn được cách nhau bởi ký tự `\` (backslash), ví dụ `C:\Users\quangphan`, tuy nhiên trên Unix/Linux thì nó là `/` (forward slash)

```cs
// get name from console then write to file using absolute path
Console.WriteLine("Enter your name:");
var name2 = Console.ReadLine();
File.WriteAllText(@"C:\Users\quangphan\Documents\new-folder\name.txt", name2);

```

Dĩ nhiên bạn sẽ nhận được kết quả như sau:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/a9e3e76f-daff-4587-92af-547a84ab2d20)

**Giải thích:** chương trình báo lỗi vì bạn đang cố gắng ghi xuống file với 1 đường dẫn không tồn tại.

**Giải pháp:** kiểm tra xem thư mục có tồn tại không, nếu không tồn tại thì tạo thư mục đó, sau đó mới ghi file.

**Các bước thực hiện:**

```
// ghi nội dung xuống file `C:\Users\quangphan\Documents\new-folder\name.txt`

1. lấy tên thư mục -> `C:\Users\quangphan\Documents\new-folder\`
2. kiểm tra thư mục có tồn tại không
3. nếu không tồn tại, tạo mới thư mục đó
4. ghi file
```

**Coding:**

```cs
// get name from console then write to file using absolute path
Console.WriteLine("Enter your name:");
var name2 = Console.ReadLine();
var filePath = @"C:\Users\quangphan\Documents\new-folder\name.txt";

// get directory name from file path
var directoryName = Path.GetDirectoryName(filePath);

// check if directory exists, if not then create it
if (!Directory.Exists(directoryName))
{
    Directory.CreateDirectory(directoryName);
}

// write to file, directory must be existed
File.WriteAllText(filePath, name2);
```

**Kết quả:**

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/211c097d-27a6-4a0a-aeeb-be2d4ecba5f7)

**💡 Notes:** tìm hiểu các hàm write file khác

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/6d91e8a8-1267-4791-921a-53244f731baf)

### Path và Directory

Với ví dụ bên trên, bạn đã "vô tình" sử dụng 2 class là `Path` và `Directory`. 2 class này cung cấp các static methods để tương tác với đường dẫn (Path) và thư mục (Directory), có thể dễ dàng hiểu ý nghĩa của các method thông qua tên hàm:

class `Path`:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/a381d117-5dfa-4bc9-b1f2-862321b2a47a)

class `Directory`:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/20b7b7b5-0a3a-4136-8945-b77a85e38121)

để dễ dàng hình dung, hãy xem xét 1 đường dẫn sau:

```
"C:\Users\quangphan\Documents\new-folder\name.txt"
```

Trong đó:

- full path: `"C:\Users\quangphan\Documents\new-folder\name.txt"`
- parent folder (directory): `"C:\Users\quangphan\Documents\new-folder\"`
- file name: `"name.txt"`
- extension: `".txt"` (có dấu `.`)
- file name without extension: `"name"`

Xem thêm:

```cs
var filePath = @"C:\Users\quangphan\source\repos\chap_06_file_and_directory\chap_06_file_and_directory\bin\Debug\net8.0\chap_06_file_and_directory.deps.json";

Console.WriteLine("- file name: " + Path.GetFileName(filePath));
Console.WriteLine("- file extension: " + Path.GetExtension(filePath));
Console.WriteLine("- file name without extension: " + Path.GetFileNameWithoutExtension(filePath));
Console.WriteLine("- path separator: " + Path.PathSeparator);
Console.WriteLine("- directory separator: " + Path.DirectorySeparatorChar);
Console.WriteLine("- parent directory: " + Path.GetDirectoryName(filePath));

var folder = Path.GetDirectoryName(filePath);
// show files to console
var files = Directory.EnumerateFiles(folder);
foreach (var file in files)
{
    var nameonly = Path.GetFileName(file);
    Console.WriteLine(nameonly);
}
```

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/ca953e62-32b4-402d-94e9-de001a8caa22)

### Kết

Trong phần này mình đã làm quen với 1 số thao tác với file và directory như:

- Đọc file với `File.ReadAllText("/path/to/file")`
- Ghi file với `File.WriteAllText("/path/to/file", content)`
- Kiểm tra directory tồn tại với `Directory.Exists("/path/to/directory")`
- Tạo directory với `Directory.CreateDirectory("/path/to/directory")`
- Hiểu về các thành phần của path như full path, separator, directory name, filename, extension
- Cách lấy tất cả các file trong 1 directory với `Directory.EnumerateFiles(/path/to/directory)`

Trong bài tiếp theo, mình sẽ ứng dụng những kiến thức này cho 1 project để có thể kết hợp các method với nhau.

