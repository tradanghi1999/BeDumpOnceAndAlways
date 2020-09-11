<!DOCTYPE html>
<html>
<head>
    <title>Nhập Mảng</title>
    <meta charset="utf-8" />
</head>
<body>
    <?php
        $value = "Nhập";
        //global $mang; 
        $mang = array(0,5,6);
        if(!$_POST)
        {

        }
        else
        {
            $value ="Nhập tiếp";
            $soNhap = (int)htmlspecialchars($_POST['So']);
            ThemVaoMang($soNhap);
        }
        function ThemVaoMang($inte)
        {
            global $mang;
            $mang[] = $inte;
        }
        function xuatChuoiGiaTri($array)
        {
            $chuoiTraVe ="";
            foreach($array as $i => $value)
            {
                $chuoiTraVe = $chuoiTraVe.'------'.$array[$i];
            }
            return $chuoiTraVe;
        }
    ?>
    
    <form method="POST" action="">
        <p>Nhập n:</p>
        <input type="text" name="So" value="" />
        <input type="submit" value="<?php echo $value;?>" />
        <?php
        if($_POST)
            {
                echo xuatChuoiGiaTri($mang);
            }
        ?>
    </form>
</body>
</html>