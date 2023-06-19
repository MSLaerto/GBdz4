int InputNumber(){
    int a = Convert.ToInt32(Console.ReadLine());
    return a ;    
}
void InOutputArray(){
    int[] result = new int[8] ;
    for (int i = 0 ; i < 8 ; i++ ){
        Console.WriteLine("Введите " + (i+1) + " число : ");
        result[i]= InputNumber();
    }
    Console.Write("Ваш массив: [ ");
    for (int i = 0 ; i < 8 ; i++ ){
        Console.Write(result[i] + " ");
    }
    Console.WriteLine("]");
}
InOutputArray();