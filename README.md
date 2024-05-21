# Custom-wc
This is a custom implementation of the Unix `wc` (word count) command.


## Usage

### Command Line Options

- `-c` : Count bytes
- `-l` : Count lines
- `-w` : Count words
- `-m` : Count characters

### Examples

#### Count bytes in a file
```sh
maliwc -c test.txt
```

#### Count lines in a file
```sh
maliwc -l test.txt
```

#### Count words in a file
```sh
maliwc -w test.txt
```

#### Count characters in a file
```sh
maliwc -m test.txt
```

#### Default behavior (counts lines, words, and bytes)
```sh
maliwc test.txt
```

#### Read from standard input
```sh
type test.txt | maliwc -l
```

## Building the Project

To build the project, you need the .NET SDK installed.

1. Clone the repository:
   ```sh
   git clone https://github.com/MohamedAliSalam/Custom-wc.git
   ```

2. Build the project:
   ```sh
   dotnet build -o ./output
   ```

3. Find the Directory:

	Locate the directory where your maliwc executable is located.(Example:```C:\User\Desktop\Custom-wc\bin\Debug\net8.0```)

4. Update the PATH Environment Variable:

	1. Open the Control Panel.
	1. Navigate to System and Security > System > Advanced system settings.
	1. In the System Properties window, click on the "Environment Variables" button.
	1. In the "System variables" section, find the variable named "Path" and select it, then click the "Edit" button.
	1. In the Edit Environment Variable window, click the "New" button and add the directory path containing the maliwc executable.
	1. Click "OK" on all windows to save the changes.

5. Open Your Terminal and run:
   ```bash
   maliwc -c "path of your file"
   ```
   It will return number of bytes

## Contributing

Feel free to open issues or submit pull requests if you find any bugs or have suggestions for improvements.

## License

This project is licensed under the MIT License.