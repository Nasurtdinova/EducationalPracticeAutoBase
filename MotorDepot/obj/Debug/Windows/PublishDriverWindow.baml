   M S B A M L   `   `   `  ????E  AMotorDepot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MotorDepot
MotorDepot  5      "    MotorDepot.PublishDriverPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MotorDepot     5      .??5
      ?   ? RowDefinitions  5   
   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6    ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!   .+?5   
   ?? $?? ??6   $??2??6   62   ?? 5   
   .+?5      ?? $&?? Откуда выезжаете???6   63   ?? 5       ?? Orientation$ 
Horizontal=?6   .+?5      ?? -   5        $??comboCityDeparture??5   ?   $??10q?6    ?? DisplayMemberPath$
 Name??6?    ?? SelectedItem 6   ?? *PlaceDeparture.City+6?   ?? 5      -   5        $??comboStreetDeparture??5   \   $
 Name??6C    6   ?? *PlaceDeparture+6z   5      5      ?? 5   
   $??1??6   .+?5      ?? $??Куда едете???6   6-   ?? 5      $ 
Horizontal=?6   .+?5       ?? -   5        $??comboCityArrival??5    ?   $??10q?6{   $
 Name??6?    6   ?? *PlaceArrival.City+6?   ?? 5!      -   5        $??comboStreetArrival??5!   Z   $
 Name??6A    6   ?? *PlaceArrival+6v   5"      5#      ?? 5$   
   $??2??6   .+?5%      ?? $(??"Когда и во сколько???6   65   (  "System.Windows.Controls.DatePicker  5&      -   5        $??dpData??5&   s      SelectedDateFormat$
 Long=?6X   $??20(?6?      SelectedDate 6   ?? *Data+ ?? StringFormat$ dd.MM.yyyy HH:mm??6?   5'      ?? 5(   
   $??2??6   .+?5)      ?? $;??5Сколько попутчиков возьмете???6   6>   ?? 5*      -   5        $??tbCountPeople??5*      ??6+   ?? *CountPeople+6J   5+      ?? 5,   
   $??1??6   $??1??6"   .+?5-      ?? $??Какая цена???6   6-   ?? 5.      -   5        $??tbPrice??5.      ??6%   ?? *Price+6>   5/      ?? 50   
   $??2??6   $??1??6"   .+?51      ?? $G??AХотите сказать о поездке что-то еще???6   6F   ?? 52      -   5        $??tbDescription??52      ??6+   ?? *Description+6J   53      ?? 54   
   $??2??6   $??3??6)   $ 
Horizontal=?66   .+?55      ?? -	   5        $??btnSend??55      $??Сохранить??6$   6P   56      57      58      