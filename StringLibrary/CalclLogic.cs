namespace StringLibrary;

public class CalclLogic
{
    private static decimal result = 0;
    public static String Add(decimal firstDigit, decimal secondDigit){
        result = firstDigit + secondDigit;
        return result.ToString();
    }

    public static String Subtract(decimal firstDigit, decimal secondDigit){
        result = firstDigit - secondDigit;
        return result.ToString();
    }

    public static String Multiply(decimal firstDigit, decimal secondDigit){
        result = firstDigit * secondDigit;
        return result.ToString();
    }

    public static String Divide(decimal firstDigit, decimal secondDigit){
        if(!secondDigit.Equals(0))
            return (firstDigit / secondDigit).ToString();
        else
            return "Error!!";
    }

    public static String Modulo(decimal firstDigit, decimal secondDigit){
        if(firstDigit == 0){
            result = 0;
            return result.ToString();
        }
        else
            if(secondDigit == 0)
                return firstDigit.ToString();
        else
            if(firstDigit < secondDigit)
                return firstDigit.ToString();
        else{
            var result1 = (int)(firstDigit / secondDigit);
            result = firstDigit - (result1 * secondDigit);
            return result.ToString();
        }
    }

}
