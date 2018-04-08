# RemiX-lang
Better than Greg's language because this one exists.
This language follows the C# syntax, but will be much easier to use.
## Executing Your Program
The default input file is **`main.rmx`**.  You can use a different input file by passing the input source as a parmeter when executing RemiX.exe.
```
RemiX.exe some_file.rmx
```

## Example Code
```
namespace RemiX
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintLine("RemiX is here!");
        }
    }
}
```
## Modifiers
- ABSTRACT
- EXTERN
- NEW
- OVERRIDE
- PARTIAL
- READONLY
- SEALED
- STATIC
- UNSAFE
- VIRTUAL
- VOLATILE
## Types
### Integral Types
- SBYTE
- BYTE 
- SHORT 
- USHORT 
- INT 
- UINT 
- LONG 
- ULONG 
- CHAR
### Other Types
- FLOAT 
- DOUBLE 
- DECIMAL 
- BOOL 
- VOID 
- OBJECT 
- STRING 

## Functions
### System
<dl>
    <dt>Note</dt>
    <dd>
        Functions.System is always available, so you won't have to include this manually with <em>using Functions.System;</em>
    </dd>
</dl>

#### *Function:* PrintLine
Prints a line to the console/terminal.
##### Arguments
*String variable* or *String literal*
##### Example
```
PrintLine("How are you?");
```
##### Output
```
> How are you?
```
***
More to come soon.
