   M S B A M L   `   `   `  ????E  AMotorDepot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MotorDepot
MotorDepot  5      !    MotorDepot.RegistrationPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MotorDepot     5        N? Title$  RegistrationPage??5	      .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6"    ? RowDefinitions 5   
   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   .+?5   
   ?? $??Регистрация??6   $??28(?6'   $??2??65   6K   ?? 5   
   $??ФИО??6   $??1??6   $??25(?6,   6<   ?? 5   
   $??Дата рождения??6   $??2??6)   $??25(?66   6F   ?? 5   
   $??Род??6   $??3??6   $??25(?6,   6<   ?? 5   
   $??
Логин??6   $??4??6!   $??25(?6.   6>   ?? 5   
   $??Пароль??6   $??5??6"   $??25(?6/   6?   ?? 5   
   -   5        $??
tbFullName??5   /   $??1??6   $??1??6"   ??6A   ?? *
FullName+6]   (  "System.Windows.Controls.DatePicker  5   
   -   5        $??dpDate??5   ;   $	??300??6   $??40??6!   $??25(?6-   $??2??6m   $??1??6z      SelectedDate 6I   ?? *
DayOfBirth+6?   ?? 5    
   -   5        $??comboGender??5    j   $??3??6   $??1??6     ?? DisplayMemberPath$
 Name??60    ?? SelectedItem 6I   ?? *	Gender1+6   ?? 5!   
   -   5        $??tbLogin??5!   /   $??1??6   $??4??6"   ??6>   ?? *Login+6W   G? 5"   
   -   5        $??
tbPassword??5"   3   $??1??6   $??5??6&   6G   ?? 5#   
    ?? Orientation$ 
Horizontal=?6   $??7??6.   $??2??6;   .+?5$      ?? -   5        $??
btnRegistr??5$   K   $*??$Зарегистрироваться??6   $??10q?6]   $	??250??6i   6w   ?? 5%      -   5        $??btnLogin??5%   %   $??
Войти??6   6N   5&      5'      5(      