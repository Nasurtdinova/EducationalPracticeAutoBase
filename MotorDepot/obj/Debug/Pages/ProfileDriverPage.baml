   M S B A M L   `   `   `  ????E  AMotorDepot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MotorDepot
MotorDepot  5      "    MotorDepot.ProfileDriverPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MotorDepot     5        N? Title$  ProfileDriverPage??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      6   ?? 5      $??3* ?6   6*   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? -   5         ??Name$	 img??5      $	??350??6!   $??20q?6-   ??5      ?? 5       ?? Path$ Image?6    ?? TargetNullValue 5      ?? 5       ?? 	UriSource$3 -/MotorDepot;component/Images/PhotoProfile.png??6*   6f   5      5      5      ?? 5   
   $??1??6   .@?5      ?? $??Данные??6   .??5      ?  5      ?? 5      6*   ?? 5       6*   ?? 5!      6*   ?? 5"      6*   .+?5$      ?? $??20q?6!   .+?5%      ?? $??ФИО??6$   61   ?? 5&      -   5         ??Name$ 
tbFullName??5&   $   ??68   ?? *
FullName+6T   5'      ?? 5(      $??1??6!   $??20q?6.   .+?5)      ?? $??Дата рождения??6$   6;   ?? 5*      -   5        $ 
tbBirthday??5*   $   $??22(?68   ??6F   ?? *
DayOfBirth+ ?? StringFormat$ 
dd.MM.yyyy??$/ )Не указана информация!??6?   5+      ?? 5,      $??2??6!   $??20q?6.   .+?5-      ?? $??Машина??6$   64   ?? 5.      $ 
Horizontal=?6%   .+?50      ?? ??6(   ?? *Car.Stamp.Name+6J   ?? 51      $??10q?6D   ??6(   ?? *	Car.Model+6R   52      53      ?? 54      $ 
Horizontal=?6!   $??3??6:   .+?55      ?? -   5        	 ??Name$	 btnBack??55   !   $??20q?6H   $??
Назад??6T   6g   56      57      58      ?? 59      $??Отзывы??6   .??5:      ?? .+?5;      ?? -   5        $??tbNoData??5;   3   $??Нет отзывов??6    $y?	Collapsed=?6C   $	??200q?6Z   6i   ?? 5<      -   5        
 ??Name$
 lvFeedBacks??5<      ??5=      ?? 5>      .R?5?   "   ?? .+?5@   &   ?? $??	Underline{?6O   ??60   ?? *User.FullName+6m   ?? 5A   &   ??60   ?? *
Feedback+6L   5B   #   5C      5E      5F      5G      5H      5I      5J      