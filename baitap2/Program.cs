using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2
{
    class Account
    {
        private string id;
        private string name;
        private int balance;
        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getID()
        {
            return id;
        }
        public string getname()
        {
            return name;
        }
        public int getBalance()
        {
            return balance;
        }
        public void credit(int amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public void debit(int amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("So tien vuot qua so du. Rut tien khong thanh cong");

        }
        public void tranferTo(Account acc, int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                acc.balance += amount;
            }
            else
            {
                Console.WriteLine("So tien vuot so du. Chuyen khoan khong thanh cong");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Account my = new Account("900111", "Le Van Ti", 600);
            Account myFriend = new Account("900112", "Be Le Van Dat", 30);
            Console.WriteLine("------Thong tin 2 tai khoan ban dau----");
            Console.WriteLine("My Account:[ id;{0}, name: {1}, balance: {2}",
                my.getID(), my.getname(), my.getBalance());
            Console.WriteLine("My Friend Account:[ id;{0}, name: {1}, balance: {2}",
                myFriend.getID(), myFriend.getname(), myFriend.getBalance());

            //rut tien

            my.debit(200);
            my.tranferTo(myFriend, 450);

            //ket qua sau khi thuc hien mot so hanh vi(nap, rut, chuyen khoan)

            Console.WriteLine("---Thong tin 2 tai khoan sau khi thuc hien giao dich---");
            Console.WriteLine("My Account:[ id;{0}, name: {1}, balance: {2}",
                 my.getID(), my.getname(), my.getBalance());
            Console.WriteLine("My Friend Account:[ id;{0}, name: {1}, balance: {2}",
               myFriend.getID(), myFriend.getname(), myFriend.getBalance());
            Console.ReadLine();
        }
    }
}

        
    

