   M S B A M L   `   `   `  ????E  AMotorDepot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MotorDepot
MotorDepot  5   	       MotorDepot.HomeWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MotorDepot     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     N? Title$  
HomeWindow??5	   	   .??5
      ? -   5        
???????.+?5   
   ?? $	??Top=?6   $	??300??6-   $
??Left=?69   $??	930,0,0,0q?6T   .+?5      ? 
??? ???$??10??6'   ?? 5      $??Попутчики??6   $??30(?6)   5      ? 5   
   $??
250 55 0 0q?6   .+?5       ? -   5          ?Name$ GridPrincipal??5        ? NavigationUIVisibility$ Hidden=?6+   $??Center=?6K   $??Center=?6h   5      ? 5   
   $	??250??6   $
??Left=?6   ???	#FF4984C5.+?5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide??5   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X?.??5      ? -   5         ?Name$ 
GridCursor??5      $??	0 150 0 0q?6+   
??? ???$??10??6R   $
??Left=?6]   $??60??6x   $	??Top=?6?   5      A? 5      $	??150??6   $	??150??6"   $	??Top=?6/   $??20q?6G   ??5      ?? 5       ?? ImageSource$2 ,/MotorDepot;component/Images/iconDrivers.jpg??6!   6^   5      ?? 5      -   5         ??Name$ ListViewMenu??5      $??0 200q?6-   $??Disabled=?6<   $??Disabled=?6r   
???????$??Champagne & Limousines)?6?   $??18(?6?   	 ?? SelectedIndex$	 0??6$  .@?5      ?? $??60??6   .??5      ?? 
 ?? Orientation$
 
Horizontal=?6!   .+?5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=?62   $??30??6>   $??30??6I   $??Center=?6U   $??5q?6p   ?? 5      $??Главная??6$   $??17(?63   $??Center=?6A   $
??20 0q?6\   5       5!      ?? 5"      $??60??6   .??5#      ?? $
 
Horizontal=?6!   .+?5$        $ FoodForkDrink=?62   $??30??6G   $??30??6R   $??Center=?6^   $??5q?6y   ?? 5%      $??Мои поездки??6$   $??17(?67   $??Center=?6E   $
??20 0q?6`   5&      5'      ?? 5(      $??60??6   .??5)      ?? $
 
Horizontal=?6!   .+?5*        $ Message=?62   $??30??6A   $??30??6L   $??Center=?6X   $??5q?6s   ?? 5+      $??Входящие??6$   $??17(?64   $??Center=?6B   $
??20 0q?6]   5,      5-      ?? 5.      $??60??6   .??5/      ?? $
 
Horizontal=?6!   .+?50        $ Account=?62   $??30??6A   $??30??6L   $??Center=?6X   $??5q?6s   ?? 51      $??Мой профиль??6$   $??17(?67   $??Center=?6E   $
??20 0q?6`   52      53      ?? 54      $??60??6   .??55      ?? $
 
Horizontal=?6!   .+?56        $ Logout=?62   $??30??6@   $??30??6K   $??Center=?6W   $??5q?6r   ?? 57      $??
Выйти??6$   $??17(?61   $??Center=?6?   $
??20 0q?6Z   58      59      5:      5;      5<      5=      