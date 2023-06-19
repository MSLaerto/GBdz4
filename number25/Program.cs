int InputNumber(){
    Console.Write("Введите число : ");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a <0 ){
        Console.Write("Число должно быть натуральным : ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;    
}
int InputPower(){
    Console.Write("Введите степень : ");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a <0 ){
        Console.Write("Степень должна быть натуральной : ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;    
}
void NumberInPower(int number , int power){
    int result = 1 ;
    for (int i = 0 ; i < power ; i++){
        result=result*number;
    }
    Console.WriteLine(result);   
}
Console.WriteLine("Введите число, а затем его степень ") ;
NumberInPower(InputNumber(), InputPower());