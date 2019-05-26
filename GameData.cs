
public static class GameData {
    private static int money, cogLoad, hubLvl, socLvl, ctrlLvl, plnLvl;
    
    //getters n' setters for the data vals
    //done thru properties (c# thing)
    public static int Money {
        get {
            return money;
        }
        set {
            money = value;
        }
    }

    public static int CogLoad {
        get {
            return cogLoad;
        }
        set {
            cogLoad = value;
        }
    }

    public static int HubLvl {
        get {
            return hubLvl;
        }
        set {
            hubLvl = value;
        }
    }

    public static int Soclvl {
        get {
            return socLvl;
        }
        set {
            socLvl = value;
        }
    }

    public static int CtrlLvl {
        get {
            return ctrlLvl;
        }
        set {
            ctrlLvl = value;
        }
    }

    public static int PlnLvl {
        get {
            return plnLvl;
        }
        set {
            plnLvl = value;
        }
    }
}
