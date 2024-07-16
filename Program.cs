
Console.WriteLine(IsValid("())(("));
Console.WriteLine(IsValid("(afeez())"));
Console.WriteLine(IsValid("(((((())"));
bool IsValid(string input)
{
    int output = 0; 
    foreach(char c in input)
    {
        if (c == '(')
        {
            output++;        
        }
        else if(c == ')') 
        {
        output --;
        if (output < 0)
          {

          return false;
          }
           
        }
      
    }
    return output == 0;
}