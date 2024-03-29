﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinPulsDaten.database {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DBQuerys {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DBQuerys() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WinPulsDaten.database.DBQuerys", typeof(DBQuerys).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die DELETE FROM `person` ähnelt.
        /// </summary>
        internal static string delete_Person {
            get {
                return ResourceManager.GetString("delete.Person", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die DELETE FROM  `pulsdata` ähnelt.
        /// </summary>
        internal static string delete_Pulsdate {
            get {
                return ResourceManager.GetString("delete.Pulsdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die DELETE FROM `person` WHERE IsSuperuser != true ähnelt.
        /// </summary>
        internal static string delete_WithoutSuperUser {
            get {
                return ResourceManager.GetString("delete.WithoutSuperUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die INSERT INTO `person` (`ID`, `Firstname`, `Lastname`, `Birthday`, `Gender`, `Bodysize`, `Weight`, `TrainingCondition`, `HFmax`, `Passwd`, `PassSalt`, `IsSuperuser`) VALUES (NULL, @fname, @lname, @birth, @gender, @bodysize, @weight, @condition, @hfmax, SHA2(CONCAT(@passwd,@salt),256), @salt, @isSup); ähnelt.
        /// </summary>
        internal static string insert_createUser {
            get {
                return ResourceManager.GetString("insert.createUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT a.Id id,a.Name name,Factor factor FROM `activity` a ähnelt.
        /// </summary>
        internal static string select_activitys {
            get {
                return ResourceManager.GetString("select.activitys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT a.Id id,a.Name name,a.Factor factor FROM `activity` a where Factor is not null ähnelt.
        /// </summary>
        internal static string select_activitysWithFactor {
            get {
                return ResourceManager.GetString("select.activitysWithFactor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT t.ID id, t.Name name FROM `trainingcondition` t ähnelt.
        /// </summary>
        internal static string select_AllTrainingCondition {
            get {
                return ResourceManager.GetString("select.AllTrainingCondition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT pld.Value val, pld.RecordTime time FROM `pulsdata` pld JOIN Person p on p.ID = pld.Person where p.ID = @person and pld.Activity = @activity and pld.Value &gt;= (220 - FLOOR(DATEDIFF(CURRENT_DATE(),p.Birthday)/365)) ähnelt.
        /// </summary>
        internal static string select_criticalPulses {
            get {
                return ResourceManager.GetString("select.criticalPulses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT CAST(SUM(p.HFmax)/COUNT(*) as INT) hf, FLOOR(DATEDIFF(CURRENT_DATE(),p.Birthday)/365) age FROM `person` p group by age order by 2; ähnelt.
        /// </summary>
        internal static string select_HfOverAge {
            get {
                return ResourceManager.GetString("select.HfOverAge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT p.ID id, p.Firstname fname, p.Lastname lname, p.Birthday birthday, p.Gender gender, p.Bodysize size, p.Weight weight, p.TrainingCondition trainCondition, p.HFmax hfmax, p.IsSuperuser isSup FROM `person` p WHERE p.Firstname = @fname and p.Lastname = @lname and p.Passwd = SHA2(CONCAT(@passwd,p.PassSalt),256) ähnelt.
        /// </summary>
        internal static string select_loginUser {
            get {
                return ResourceManager.GetString("select.loginUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT pld.RecordTime time, pld.Value val FROM person p JOIN pulsdata pld on pld.person = p.ID where p.ID = @person and pld.Activity = @activity order by 1 ähnelt.
        /// </summary>
        internal static string select_personPulseOverTime {
            get {
                return ResourceManager.GetString("select.personPulseOverTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Select CAST(SUM(pld.Value)/Count(*) as int) pulse, p.Weight weight from person p Join pulsdata pld on pld.Person = p.ID Join activity a on a.Id = pld.Activity where
        ///a.Id = 1 group by p.ID order by 2 ähnelt.
        /// </summary>
        internal static string select_RestpulsOverWeight {
            get {
                return ResourceManager.GetString("select.RestpulsOverWeight", resourceCulture);
            }
        }
    }
}
