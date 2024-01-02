using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int size = int.Parse(Console.ReadLine());
                int count1=0;
                int count2=0;

                int[] array = new int[size];
                
                for(int i=0;i<array.Length;i++)
                {
                    array[i]=int.Parse(Console.ReadLine());
                }


                for(int i=0;i<array.Length;i++)
                {   
                    if(array[i]%2==0)
                    {
                        count1++;
                        
                    }
                    else
                    {
                        count2++;
                    }
                    
                }
                int[] odd = new int[count2];
                int[] even = new int[count1];
                
                for(int i=0,j=0,k=0;i<array.Length;i++)
                {
                    if(array[i]%2==0)
                    {
                        even[j++] = array[i];
                    }
                    else
                    {
                        odd[k++] = array[i];
                    }
                }


                for(int i=0;i<odd.Length;i++)
                {
                    for(int j=i+1;j<odd.Length;j++)
                    {
                        if(odd[i]<odd[j])
                        {
                            int temp = odd[i];
                            odd[i] = odd[j];
                            odd[j] = temp;
                        }
                    }
                }

                Console.Write("Even Numbers : ");
                for(int i=0;i<even.Length;i++)
                {
                    Console.Write(even[i]+" ");
                }

                Console.WriteLine();

                 Console.Write("Odd Numbers : ");
                for(int i=0;i<odd.Length;i++)
                {
                    Console.Write(odd[i]+" ");
                }
            }
        }