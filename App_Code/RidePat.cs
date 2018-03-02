﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
}