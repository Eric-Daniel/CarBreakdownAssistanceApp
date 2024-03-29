﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EricDaniel_Assignment.Classes
{
    [Serializable]
    public abstract class Member
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        private string icNum;

        public string IcNum
        {
            get { return icNum; }
        }

        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
        }

        private string phoneNum;

        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        private Car mCar;

        public Car MCar
        {
            get { return mCar; }
            set { mCar = value; }
        }

        protected string membershipRenewalDate;

        public string MembershipRenewalDate
        {
            get { return membershipRenewalDate; }

        }

        public Member(string aName, string theIc, DateTime theDOB, string aPhoneNum, string aNewDate,
            string registrationNumber, string model, int year)
        {

            name = aName;
            icNum = theIc;
            dateOfBirth = theDOB;
            phoneNum = aPhoneNum;
            membershipRenewalDate = aNewDate;
            mCar = new Car(registrationNumber, model, year);
        }

        public abstract void RenewMembership();
    }

    [Serializable]
    public class OneYearMembershipRenewal : Member
    {
        public OneYearMembershipRenewal(string name, string ic, DateTime dOB, string phoneNum,
            string newDate, string registrationNumber, string model, int year) : base(name, ic, dOB, phoneNum, newDate, registrationNumber, model, year)
        {

        }

        public override void RenewMembership()
        {
            DateTime date = Convert.ToDateTime(membershipRenewalDate);
            date = date.AddYears(1);

            membershipRenewalDate = Convert.ToString(date.ToShortDateString());

        }
    }

    [Serializable]
    public class FiveYearsMembershipRenewal : Member
    {
        public FiveYearsMembershipRenewal(string name, string ic, DateTime dOB, string phoneNum,
            string newDate, string registrationNumber, string model, int year) : base(name, ic, dOB, phoneNum, newDate, registrationNumber, model, year)
        {

        }

        public override void RenewMembership()
        {
            DateTime date = Convert.ToDateTime(membershipRenewalDate);
            date = date.AddYears(5);

            membershipRenewalDate = Convert.ToString(date.ToShortDateString());

        }
    }
}