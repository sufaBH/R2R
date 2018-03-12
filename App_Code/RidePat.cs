using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

/// <summary>
/// Summary description for RidePat
/// </summary>
public class RidePat
{
    int ridePatNum;//מספר הסעה
    Patient pat;//חולה
    Escorted escorted1;//נלקח מהמלווים של החולה
    Escorted escorted2;//נלקח מהמלווים של החולה
    Escorted escorted3;//נלקח מהמלווים של החולה
    Destination startPlace;//מקום התחלה
    Destination target;//מקום סיום
    string startArea;
    string finishArea;
    string day;// יום
    string date; //תאריך
    string leavingHour;//שעת יציאה
    int quantity;//כמות מלווים
    string addition;//כלי עזר
    string rideType;//סוג הסעה
    Volunteer coordinator; //רכז אחראי
    string remark;//הערות
    string status;

    public RidePat()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public RidePat(Patient _pat, Escorted _escorted1, Destination _startPlace, Destination _target,
       string _day, string _date, string _leavingHour, int _quantity, string _addition, string _rideType,
       Volunteer _coordinator, string _remark, string _status)
    {
        Pat = _pat;
        Escorted1 = _escorted1;
        StartPlace = _startPlace;
        Target = _target;
        Day = _day;
        Date = _date;
        LeavingHour = _leavingHour;
        Quantity = _quantity;
        Addition = _addition;
        RideType = _rideType;
        Coordinator = _coordinator;
        Remark = _remark;
        Status = _status;
    }
    public RidePat(int _ridePatNum, Escorted _escorted1, Escorted _escorted2, Escorted _escorted3, Destination _startPlace, Destination _target,
       string _day, string _date, string _leavingHour, int _quantity, string _addition, string _rideType,
       Volunteer _coordinator, string _remark, string _status)
    {
        RidePatNum = _ridePatNum;
        Escorted1 = _escorted1;
        Escorted2 = _escorted2;
        Escorted3 = _escorted3;
        StartPlace = _startPlace;
        Target = _target;
        Day = _day;
        Date = _date;
        LeavingHour = _leavingHour;
        Quantity = _quantity;
        Addition = _addition;
        RideType = _rideType;
        Coordinator = _coordinator;
        Remark = _remark;
        Status = _status;
    }

    public int RidePatNum
    {
        get
        {
            return ridePatNum;
        }

        set
        {
            ridePatNum = value;
        }
    }

    public Patient Pat
    {
        get
        {
            return pat;
        }

        set
        {
            pat = value;
        }
    }

    public Escorted Escorted1
    {
        get
        {
            return escorted1;
        }

        set
        {
            escorted1 = value;
        }
    }

    public Escorted Escorted2
    {
        get
        {
            return escorted2;
        }

        set
        {
            escorted2 = value;
        }
    }

    public Escorted Escorted3
    {
        get
        {
            return escorted3;
        }

        set
        {
            escorted3 = value;
        }
    }

    public Destination StartPlace
    {
        get
        {
            return startPlace;
        }

        set
        {
            startPlace = value;
        }
    }

    public Destination Target
    {
        get
        {
            return target;
        }

        set
        {
            target = value;
        }
    }

    public string StartArea
    {
        get
        {
            return startArea;
        }

        set
        {
            startArea = value;
        }
    }

    public string FinishArea
    {
        get
        {
            return finishArea;
        }

        set
        {
            finishArea = value;
        }
    }

    public string Day
    {
        get
        {
            return day;
        }

        set
        {
            day = value;
        }
    }

    public string Date
    {
        get
        {
            return date;
        }

        set
        {
            date = value;
        }
    }

    public string LeavingHour
    {
        get
        {
            return leavingHour;
        }

        set
        {
            leavingHour = value;
        }
    }

    public int Quantity
    {
        get
        {
            return quantity;
        }

        set
        {
            quantity = value;
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

    public string RideType
    {
        get
        {
            return rideType;
        }

        set
        {
            rideType = value;
        }
    }

    public Volunteer Coordinator
    {
        get
        {
            return coordinator;
        }

        set
        {
            coordinator = value;
        }
    }

    public string Remark
    {
        get
        {
            return remark;
        }

        set
        {
            remark = value;
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


    //public DataTable read()
    //{
    //    DBservices dbs = new DBservices();
    //    dbs = dbs.ReadFromDataBase("RoadDBconnectionString", "RidePat");
    //    return dbs.dt;
    //}


    public List<RidePat> getRidePatsList(bool active)
    {
        #region DB functions
        string query = "select * from RidePat r";
        if (active)
        {
            query += " where r.statusRidePat <> 'לא פעיל'";
        }

        //query += " order by firstNameH";

        List<RidePat> list = new List<RidePat>();
        DbService db = new DbService();
        DataSet ds = db.GetDataSetByQuery(query);

        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            RidePat v = new RidePat();
            v.RidePatNum =Convert.ToInt32(dr["ridePatNum"]);
            v.Pat =new Patient(dr["patient"].ToString());
            v.StartPlace =new Destination(dr["startPlace"].ToString());
            v.Target =new Destination(dr["finishPlace"].ToString());
            v.Day = dr["dayRide"].ToString();
            v.Date = dr["dateRide"].ToString();
            v.LeavingHour = dr["hourRide"].ToString();
            v.Quantity = Convert.ToInt32(dr["quantity"]);
            v.Addition = dr["addition"].ToString();
            v.RideType = dr["rideType"].ToString();
            v.Coordinator =new Volunteer(dr["coordinator"].ToString());
            v.Remark = dr["remark"].ToString();
            v.Status = dr["statusRidePat"].ToString();
            v.Escorted1 =new Escorted(dr["escorted"].ToString());
            v.Escorted2 = new Escorted(dr["escorted1"].ToString());
            v.Escorted3 = new Escorted(dr["escorted2"].ToString());
            v.StartArea = dr["Area"].ToString();

            list.Add(v);
        }
        #endregion

        return list;
    }

    public RidePat getRidePat()
    {
        #region DB functions
        string query = "select ridePatNum, patient, startPlace, finishPlace, dayRide, dateRide, " +
            "hourRide, quantity, addition, rideType, coordinator, remark, statusRidePat, escorted, escorted1, " +
            "escorted2, Area where ridePatNum ='" + ridePatNum + "'";
        RidePat v = new RidePat();
        DbService db = new DbService();
        DataSet ds = db.GetDataSetByQuery(query);

        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            v.RidePatNum = Convert.ToInt32(dr["ridePatNum"]);
            v.Pat = new Patient(dr["patient"].ToString());
            v.StartPlace = new Destination(dr["startPlace"].ToString());
            v.Target = new Destination(dr["finishPlace"].ToString());
            v.Day = dr["dayRide"].ToString();
            v.Date = dr["dateRide"].ToString();
            v.LeavingHour = dr["hourRide"].ToString();
            v.Quantity = Convert.ToInt32(dr["quantity"]);
            v.Addition = dr["addition"].ToString();
            v.RideType = dr["rideType"].ToString();
            v.Coordinator = new Volunteer(dr["coordinator"].ToString());
            v.Remark = dr["remark"].ToString();
            v.Status = dr["statusRidePat"].ToString();
            v.Escorted1 = new Escorted(dr["escorted"].ToString());
            v.Escorted2 = new Escorted(dr["escorted1"].ToString());
            v.Escorted3 = new Escorted(dr["escorted2"].ToString());
            v.StartArea = dr["Area"].ToString();

        }
        #endregion

        return v;
    }


    public void setRidePat(string func)
    {
        DbService db = new DbService();
        string query = "";
        if (func == "edit")
        {
            query = "UPDATE ridePat SET ridePatNum = '" + RidePatNum + "', patient = '" + Pat.DisplayName + "', startPlace = '" + StartPlace.Name + "'," +
                " finishPlace = '" + Target.Name + "', dayRide = '" + Day + "', dateRide = '" + Date + "'," +
                " hourRide = '" + LeavingHour +
            "', quantity = '" + Quantity + "', addition = '" + Addition + "', rideType = '" + RideType + "'," +
            " coordinator = '" + Coordinator.DisplayName + "', remark = '" + Remark + "', statusRidePat = '" + Status + "', escorted = '" + Escorted1.DisplayName + "'," +
            " escorted1 = '" + Escorted2.DisplayName + "', escorted2 = '" + Escorted3.DisplayName +
            "', Area = '" + StartArea + "' WHERE ridePatNum = '" + RidePatNum + "'";
        }
        else if (func == "new")
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Values('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}', '{11}', '{12}','{13}','{14}','{15}','{16}')",
                RidePatNum, Pat.DisplayName, StartPlace.Name, Target.Name, Day,
                Date, LeavingHour, Quantity, Addition, RideType,
                Coordinator.DisplayName, Remark, Status, Escorted1.DisplayName,
                Escorted2.DisplayName,Escorted3.DisplayName,StartArea);
            String prefix = "INSERT INTO ridePat " + "(ridePatNum, patient,startPlace, finishPlace,dayRide, " +
                "dateRide,hourRide,quantity,addition,street, rideType,coordinator ,remark ,statusRidePat,escorted,escorted1," +
                "escorted2,Area)";
            query = prefix + sb.ToString();
            //query = "insert into Customers values ('" + CustomerName + "','" + CustomerContactName + "','" + AccountID + "','Y','" + Phone1 + "','" + Phone2 + "','" + Email + "'," + PaymentType.PaymentTypeID + ",'" + Comments + "'," + PreferedDrivers.DriverID + ", '" + RegistrationNumber + "', '" + BillingAddress + "')";
        }
        db.ExecuteQuery(query);
    }

    public void deactivateRidePat(string active)
    {
        DbService db = new DbService();
        db.ExecuteQuery("UPDATE RidePat SET statusRidePat='" + active + "' WHERE ridePatNum='" + RidePatNum + "'");
    }
}