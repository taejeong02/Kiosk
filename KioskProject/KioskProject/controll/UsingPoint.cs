using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using KioskProject.entity;

namespace KioskProject
{
    public static class UsingPoint
    {
        private static int _paymentAmount;
        private static int _Point;
        private static int _UsePoint;
        private static int _savePoint;
        private static int _finalPoint;
        private static string _phoneNumber;
        public static void SetPhoneNumber(string phone)
        {
            _phoneNumber = phone;
        }
        public static void SetPayment(int payment)
        {
            _paymentAmount = payment;
        }
        public static void SetSavePoint(int savepoint)
        {
            _savePoint = savepoint;
        }
        public static void SetUsePoint(int usepoint)
        {
            _UsePoint = usepoint;
        }
        public static int FindPoint(string phone)
        {
            if (!IsExistingUser(phone))
                InsertUser(phone);

            return GetPoint(phone);
        }
        public static bool IsExistingUser(string phone)
        {
            bool exists = UserDB.IsExistingUser(phone);
            return exists;
        }
        public static void InsertUser(string phone)
        {
            UserDB.InsertUser(phone);
        }
        public static int GetPoint(string phone)
        {
            _Point = UserDB.GetPoint(phone);
            return _Point;
        }
        public static int UsePoint()
        {
            _Point = UserDB.GetPoint(_phoneNumber);
            _finalPoint = _Point - _UsePoint;
            UpdatePoint();
            return _finalPoint;
        }
        public static int AddPoint()
        {
            if (_savePoint < 0) _savePoint = 0; // 음수 적립 방지
            _Point = UserDB.GetPoint(_phoneNumber);
            _finalPoint = _Point + _savePoint;
            UpdatePoint();
            return _finalPoint;
        }
        public static void UpdatePoint()
        {
            UserDB.UpdatePoint(_phoneNumber, _finalPoint);
        }
    }
}
