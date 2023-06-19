int InputNumber(){
    Console.Write("Введите число : ");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a <0 ){
        Console.Write("Число должно быть натуральным : ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;    
}
void SumOfNumbers(int number){
    int result = 0 ;
    while (number > 0){
        result=result+number%10;
        number=number/10;
    }
    Console.Write("Сумма цифр в числе: ") ;
    Console.WriteLine(result);   
}
SumOfNumbers(InputNumber());