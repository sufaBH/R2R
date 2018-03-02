using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

/// <summary>
/// Summary description for Patient
/// </summary>
public class Patient
{
    string displayName; //מזהה ייחודי
    int id;//תעודת זהות
    string firstNameH;// שם פרטי בעברית
    string firstNameA;// שם פרטי בערבית
    string lastNameH;// שם משפחה בעברית
    string lastNameA;// שם משפחה בערבית
    string birthDate;// תאריך לידה
    string city;//יישוב
    Destination barrier;//מחסום
    Destination hospital;//בית חולים
    string department;//מחלקה
    string gender;//מין
    int cellPhone;//טלפון נייד
    int cellPhone1;//טלפון נייד1
    int homePhone;//טלפון
    string livingArea;//אזור (מחסום)
    List<Escorted> escortedList;//מלווים
    List<RidePat> ridePatList;//הסעות חולה
    string addition;//כלי עזר
    string history;//היסטוריה רפואית
    string status;//סטטוס
    string remarks;//הערות

    public string DisplayName
    {
        get
        {
            return displayName;
        }

        set
        {
            displayName = value;
        }
    }

    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    public string FirstNameH
    {
        get
        {
            return firstNameH;
        }

        set
        {
            firstNameH = value;
        }
    }

    public string FirstNameA
    {
        get
        {
            return firstNameA;
        }

        set
        {
            firstNameA = value;
        }
    }

    public string LastNameH
    {
        get
        {
            return lastNameH;
        }

        set
        {
            lastNameH = value;
        }
    }

    public string LastNameA
    {
        get
        {
            return lastNameA;
        }

        set
        {
            lastNameA = value;
        }
    }

    public string BirthDate
    {
        get
        {
            return birthDate;
        }

        set
        {
            birthDate = value;
        }
    }

    public string City
    {
        get
        {
            return city;
        }

        set
        {
            city = value;
        }
    }

    public Destination Barrier
    {
        get
        {
            return barrier;
        }

        set
        {
            barrier = value;
        }
    }

    public Destination Hospital
    {
        get
        {
            return hospital;
        }

        set
        {
            hospital = value;
        }
    }

    public string Department
    {
        get
        {
            return department;
        }

        set
        {
            department = value;
        }
    }

    public string Gender
    {
        get
        {
            return gender;
        }

        set
        {
            gender = value;
        }
    }

    public int CellPhone
    {
        get
        {
            return cellPhone;
        }

        set
        {
            cellPhone = value;
        }
    }

    public int CellPhone1
    {
        get
        {
            return cellPhone1;
        }

        set
        {
            cellPhone1 = value;
        }
    }

    public int HomePhone
    {
        get
        {
            return homePhone;
        }

        set
        {
            homePhone = value;
        }
    }

    public string LivingArea
    {
        get
        {
            return livingArea;
        }

        set
        {
            livingArea = value;
        }
    }

    public List<Escorted> EscortedList
    {
        get
        {
            return escortedList;
        }

        set
        {
            escortedList = value;
        }
    }

    public List<RidePat> RidePatList
    {
        get
        {
            return ridePatList;
        }

        set
        {
            ridePatList = value;
        }
    }

    public string Addition
    {
        get
        {
            return addition;
        }

        set
        {
            addition = value;
        }
    }

    public string History
    {
        get
        {
            return history;
        }

        set
        {
            history = value;
        }
    }

    public string Status
    {
        get
        {
            return status;
        }

        set
        {
            status = value;
        }
    }

    public string Remarks
    {
        get
        {
            return remarks;
        }

        set
        {
            remarks = value;
        }
    }

    public Patient()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Patient(string _firstNameH, string _lastNameH, int _cellPhone)
    {
        FirstNameH = _firstNameH;
        LastNameH = _lastNameH;
        CellPhone = _cellPhone;
    }

    public Patient(string _displayName, string _firstNameH, string _lastNameH, int _cellPhone)
    {
        DisplayName = _displayName;
        FirstNameH = _firstNameH;
        LastNameH = _lastNameH;
        CellPhone = _cellPhone;
    }
    public Patient(string _displayName)
    {
        DisplayName = _displayName;
    }


    public Patient(string _firstNameH, string _firstNameA, string _lastNameH, string _lastNameA, int _cellPhone, int _cellPhone1, int _homePhone,
      string _city, string _gender, string _birthdate, Destination _barrier, Destination _hospital,
      string _department, string _area, string _status, string _addition, string _history, string _remarks)
    {
        FirstNameH = _firstNameH;
        LastNameH = _lastNameH;
        FirstNameA = _firstNameA;
        LastNameA = _lastNameA;
        CellPhone = _cellPhone;
        CellPhone1 = _cellPhone1;
        HomePhone = _homePhone;
        City = _city;
        Gender = _gender;
        BirthDate = _birthdate;
        Barrier = _barrier;
        Hospital = _hospital;
        Department = _department;
        LivingArea = _area;
        Status = _status;
        Addition = _addition;
        Remarks = _remarks;
        History = _history;
    }

    public Patient(string _displayName, string _firstNameH, string _firstNameA, string _lastNameH, string _lastNameA, int _cellPhone,
        int _cellPhone1, int _homePhone, string _city, string _gender, string _birthdate, Destination _barrier, Destination _hospital,
      string _department, string _area, string _status, string _addition, string _history, string _remarks)
    {
        FirstNameH = _firstNameH;
        LastNameH = _lastNameH;
        FirstNameA = _firstNameA;
        LastNameA = _lastNameA;
        CellPhone = _cellPhone;
        CellPhone1 = _cellPhone1;
        HomePhone = _homePhone;
        City = _city;
        Gender = _gender;
        BirthDate = _birthdate;
        Barrier = _barrier;
        Hospital = _hospital;
        Department = _department;
        LivingArea = _area;
        Status = _status;
        Addition = _addition;
        Remarks = _remarks;
        History = _history;
    }


    //public DataTable read()
    //{
    //    DBservices dbs = new DBservices();
    //    dbs = dbs.ReadFromDataBase("RoadDBconnectionString", "Patient");
    //    return dbs.dt;
    //}


    //public List<Patient> getListPatient()
    //{
    //    DBservices dbs = new DBservices();
    //    List<Patient> listp = new List<Patient>();
    //    listp = dbs.getListPatient("RoadDBconnectionString", "Patient");
    //    return listp;
    //}

    //public List<Patient> getPatientInHospitals(string hospital)
    //{
    //    DBservices dbs = new DBservices();
    //    List<Patient> listp = new List<Patient>();
    //    listp = dbs.getPatientInHospitals("RoadDBconnectionString", "Patient", hospital );
    //    return listp;
    //}

    //    public string getAdditionOfPatient(string displayName)
    //{
    //    DBservices dbs = new DBservices();
    //    string addition;
    //    addition = dbs.getAdditionOfPatient("RoadDBconnectionString", "Patient", displayName);
    //    return addition;
    //}


    //public Patient gePatient(string phoneNumber)
    //{
    //    DBservices dbs = new DBservices();
    //    Patient p = new Patient();
    //    p = dbs.getPatient("RoadDBconnectionString", "Patient", phoneNumber);
    //    p.RidePatList= dbs.getRideList("RoadDBconnectionString", "Patient", phoneNumber);
    //    p.EscortedList = dbs.getEscortedList("RoadDBconnectionString", "Patient", phoneNumber);
    //    return p;
    //}


    public List<Patient> getPatientsList(bool active)
    {
        #region DB functions
        string query = "select * from Patient p";
        if (active)
        {
            query += " where p.statusPatient = 'פעיל'";
        }

        query += " order by firstNameH";

        List<Patient> list = new List<Patient>();
        DbService db = new DbService();
        DataSet ds = db.GetDataSetByQuery(query);

        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            Patient p = new Patient();
            p.DisplayName = dr["displayName"].ToString();
            p.FirstNameA = dr["firstNameA"].ToString();
            p.FirstNameH = dr["firstNameH"].ToString();
            p.LastNameH = dr["lastNameH"].ToString();
            p.LastNameA = dr["lastNameA"].ToString();
            p.CellPhone = Convert.ToInt32(dr["cellPhone"]);
            p.CellPhone1 = Convert.ToInt32(dr["cellPhone2"]);
            p.HomePhone = Convert.ToInt32(dr["homePhone"]);
            p.City = dr["city"].ToString();
            p.LivingArea = dr["livingArea"].ToString();
            p.Status = dr["statusPatient"].ToString();
            p.Addition = dr["addition"].ToString();
            p.BirthDate = dr["birthdate"].ToString();
            p.History = dr["history"].ToString();
            p.Department = dr["department"].ToString();
            p.Barrier = new Destination(dr["barrier"].ToString());
            p.Hospital = new Destination(dr["hospital"].ToString());
            p.Gender = dr["gender"].ToString();
            p.Remarks = dr["remarks"].ToString();

            list.Add(p);
        }
        #endregion

        return list;
    }

    public Patient getPatient()
    {
        #region DB functions
        string query = "select displayName, firstNameA, firstNameH, lastNameH, lastNameA, cellPhone, cellPhone2, homePhone, city, livingArea, statusPatient, birthdate, addition, history, department, barrier, hospital, gender, remarks from Patient where displayName ='" + displayName + "'";
        Patient p = new Patient();
        DbService db = new DbService();
        DataSet ds = db.GetDataSetByQuery(query);

        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            p.DisplayName = dr["displayName"].ToString();
            p.FirstNameA = dr["firstNameA"].ToString();
            p.FirstNameH = dr["firstNameH"].ToString();
            p.LastNameH = dr["lastNameH"].ToString();
            p.LastNameA = dr["lastNameA"].ToString();
            p.CellPhone = Convert.ToInt32(dr["cellPhone"]);
            p.CellPhone1 = Convert.ToInt32(dr["cellPhone2"]);
            p.HomePhone = Convert.ToInt32(dr["homePhone"]);
            p.City = dr["city"].ToString();
            p.LivingArea = dr["livingArea"].ToString();
            p.Status = dr["statusPatient"].ToString();
            p.Addition = dr["addition"].ToString();
            p.BirthDate = dr["birthdate"].ToString();
            p.History = dr["history"].ToString();
            p.Department = dr["department"].ToString();
            p.Barrier = new Destination(dr["barrier"].ToString());
            p.Hospital = new Destination(dr["hospital"].ToString());
            p.Gender = dr["gender"].ToString();
            p.Remarks = dr["remarks"].ToString();

        }
        #endregion

        return p;
    }

    public void deactivatePatient(string active)
    {
        DbService db = new DbService();
        db.ExecuteQuery("UPDATE Patient SET statusPatient='" + active + "' WHERE displayName='" + DisplayName + "'");
    }

    public void setPatient(string func)
    {
        DbService db = new DbService();
        string query = "";
        if (func == "edit")
        {
            query = "UPDATE Patient SET displayName = '" + DisplayName + "', firstNameH = '" + FirstNameH + "', firstNameA = '" + FirstNameA + "', lastNameH = '" + LastNameH + "', lastNameA = '" + LastNameA + "', cellPhone = '" + CellPhone + "', cellPhone2 = " + CellPhone1 +
            ", homePhone = '" + HomePhone + "', city = '" + City + "', livingArea = '" + LivingArea + "', statusPatient = '" + Status + "', addition = '" + Addition + "', birthdate = '" + BirthDate + "', history = '" + History + "', department = '" + Department + "', barrier = '" + Barrier +
            "', hospital = '" + Hospital + "', gender = '" + Gender + "', remarks = '" + Remarks + "' WHERE displayName = '" + DisplayName + "'";
        }
        else if (func == "new")
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Values('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}', '{11}', '{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}')",
                DisplayName, FirstNameH, FirstNameA, LastNameH, LastNameA,
                CellPhone, CellPhone1, HomePhone, City, LivingArea,
                Status, Addition, BirthDate, History, Department,
                Barrier, Hospital, Gender, Remarks);
            String prefix = "INSERT INTO Volunteer " + "(displayName, firstNameH,firstNameA, lastNameH,lastNameA, cellPhone,cellPhone2,homePhone,city,livingArea, statusPatient,addition ,birthdate ,history,department,barrier,hospital,gender,remarks)";
            query = prefix + sb.ToString();
            //query = "insert into Customers values ('" + CustomerName + "','" + CustomerContactName + "','" + AccountID + "','Y','" + Phone1 + "','" + Phone2 + "','" + Email + "'," + PaymentType.PaymentTypeID + ",'" + Comments + "'," + PreferedDrivers.DriverID + ", '" + RegistrationNumber + "', '" + BillingAddress + "')";
        }
        db.ExecuteQuery(query);
    }
}