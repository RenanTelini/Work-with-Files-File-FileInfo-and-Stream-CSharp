# Work with Files - File, FileInfo and Stream in C#

#### This exercise is based on the <a href="https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/?couponCode=MT260714G2">"C# COMPLETO Programação Orientada a Objetos + Projetos"</a> course.

#### This exercises covers the use of static members from File, FileInfo class and your functions, Using block, FileStream, StreamReader, StreamWriter, Directory, DirectoryInfo and Path in C#.

### <ins>File - Static members</ins>

- Static members (simple, but performs a security check for each operation).

### <ins>Class FileInfo</ins>

- Instance members (you need to instantiate a FileInfo class to use its methods).

### <ins>FileStream</ins>

- Provides a stream associated with a file, enabling read and write operations.

- Support for binary data.

### <ins>StreamReader</ins>

- It is a stream capable of reading characters from a binary stream (e.g., FileStream).

- Support for text-format data.

### <ins>Using Block</ins>

- Simplified syntax that ensures IDisposable objects are closed.

- IDisposable objects are NOT managed by the CLR. They must be closed manually. Examples: Font, FileStream, StreamReader, StreamWriter."

### <ins>StreamWriter</ins>

- It is a stream capable of writing characters from a binary stream (e.g., FileStream).
- Supports data in text format.

### <ins>Directory and DirectoryInfo</ins>

- Operations with folders (create, enumerate, get files, etc.)

- Directory - Static members (simple, but performs security check for each operation).

- DirectoryInfo - Instance members.

### <ins>Path</ins>

- Performs operations on strings containing information about files or folders.

### <ins>File - Exercise01</ins>

#### Read the path of a .csv file containing data about sold items. Each item has a name, unit price, and quantity, separated by commas.

#### The program should generate a new file named summary.csv, located in a subfolder called out inside the original source file's directory.

#### The output file should contain only the item name and its total value (unit price multiplied by quantity), as shown in the example.

#### Example:

#### Source file:
TV LED,1290.99,1<br>
Video Game Chair,350.50,3<br>
Iphone X,900.00,2<br>
Samsung Galaxy 9,850.00,2

#### Output file (out/summary.csv):
TV LED,1290.99<br>
Video Game Chair,1051.50<br>
Iphone X,1800.00<br>
Samsung Galaxy 9,1700.00