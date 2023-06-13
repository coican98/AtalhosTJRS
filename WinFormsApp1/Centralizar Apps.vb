Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SDM_Click(sender As Object, e As EventArgs) Handles SDM.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://atendimento.tjrs.jus.br/CAisd/pdmweb.exe")
    End Sub

    Private Sub Citsmart_Click(sender As Object, e As EventArgs) Handles Citsmart.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://cadi.citsmartcloud.com/citsmart/pages/smartPortal/smartPortal.load")
    End Sub

    Private Sub SEGUR_Click(sender As Object, e As EventArgs) Handles SEGUR.Click
        Dim seg() = Process.GetProcessesByName("segur")
        For Each Process As Process In seg
            Process.Kill()
        Next

        Process.Start("W:\Sistemas-EXE\Segur\Nova versão\Segur.exe")
    End Sub

    Private Sub Corporativo_Click(sender As Object, e As EventArgs) Handles Corporativo.Click
        Dim cppes() = Process.GetProcessesByName("Estrut_Producao")
        For Each Process As Process In cppes
            Process.Kill()
        Next

        Process.Start("W:\sistemas-exe\Corporativo\Estrut_Producao.exe")
    End Sub

    Private Sub RHE_Click(sender As Object, e As EventArgs) Handles RHE.Click
        Dim rhe() = Process.GetProcessesByName("jp2launcher")
        For Each Process As Process In rhe
            Process.Kill()
        Next

        Process.Start("javaws", "D:\RHE")
    End Sub

    Private Sub WebCTJ_Click(sender As Object, e As EventArgs) Handles WebCTJ.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://www.tjrs.gov.br/webctjv1/login.jsp")
    End Sub

    Private Sub t1gadm_Click(sender As Object, e As EventArgs) Handles t1gadm.Click
        Dim t1gadm() = Process.GetProcessesByName("Themis1GAdm")
        For Each Process As Process In t1gadm
            Process.Kill()
        Next

        Process.Start("W:\sistemas-exe\Themis1G\Themis1GAdm.exe")
    End Sub

    Private Sub IDM01_Click(sender As Object, e As EventArgs) Handles IDM01.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://idm-prd-01.tjrs.gov.br:14000/identity/faces/signin?_afrLoop=69482834113954199&_afrWindowMode=0&_afrWindowId=null&_adf.ctrl-state=1b4lavrjy3_6")
    End Sub

    Private Sub IDM02_Click(sender As Object, e As EventArgs) Handles IDM02.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://idm-prd-02.tjrs.gov.br:14000/identity/faces/signin?_afrLoop=69482834113954199&_afrWindowMode=0&_afrWindowId=null&_adf.ctrl-state=1b4lavrjy3_6")
    End Sub

    Private Sub SeloDigital_Click(sender As Object, e As EventArgs) Handles SeloDigital.Click
        Dim selo() = Process.GetProcessesByName("SeloConsole")
        For Each Process As Process In selo
            Process.Kill()
        Next

        Process.Start("W:\sistemas-exe\Selo\DisparadorSelo.exe")
    End Sub

    Private Sub FecharApps_Click(sender As Object, e As EventArgs) Handles FecharApps.Click
        Dim seg() = Process.GetProcessesByName("segur")
        For Each Process As Process In seg
            Process.Kill()
        Next

        Dim cppes() = Process.GetProcessesByName("Estrut_Producao")
        For Each Process As Process In cppes
            Process.Kill()
        Next

        Dim rhe() = Process.GetProcessesByName("jp2launcher")
        For Each Process As Process In rhe
            Process.Kill()
        Next

        Dim t1gadm() = Process.GetProcessesByName("Themis1GAdm")
        For Each Process As Process In t1gadm
            Process.Kill()
        Next

        Dim selo() = Process.GetProcessesByName("SeloConsole")
        For Each Process As Process In selo
            Process.Kill()
        Next

        Dim ad() = Process.GetProcessesByName("mmc")
        For Each Process As Process In ad
            Process.Kill()
        Next

        Dim vinculacalcp() = Process.GetProcessesByName("VinculaUsuarioEquipe")
        For Each Process As Process In vinculacalcp
            Process.Kill()
        Next

        Dim terminalprocergs() = Process.GetProcessesByName("pw3270")
        For Each Process As Process In terminalprocergs
            Process.Kill()
        Next

        Dim pdfsam() = Process.GetProcessesByName("javaw")
        For Each Process As Process In pdfsam
            Process.Kill()
        Next


    End Sub

    Private Sub AD_Click(sender As Object, e As EventArgs) Handles AD.Click
        System.Diagnostics.Process.Start("D:\AD.bat")
    End Sub

    Private Sub LogsIDM_Click(sender As Object, e As EventArgs) Handles LogsIDM.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://infra.tjrs.gov.br/serverlogs/LogInfo.aspx?name=idm-prd-01.tjrs.gov.br&logdir=/u01/oracle/connectorServer/connectorServer1.4/logs/")
    End Sub

    Private Sub IDMadm_Click(sender As Object, e As EventArgs) Handles IDMadm.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://idm-prd-01.tjrs.gov.br:14000/sysadmin/faces/signin?_adf.ctrl-state=14afkw37ek_1&_afrLoop=3590706176572542&_afrWindowMode=0&_afrWindowId=null")
    End Sub

    Private Sub idmBI_Click(sender As Object, e As EventArgs) Handles idmBI.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://idm-prd-01.tjrs.gov.br:9704/xmlpserver/servlet/home")
    End Sub

    Private Sub SEEU_Click(sender As Object, e As EventArgs) Handles SEEU.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://seeu.pje.jus.br/seeu/")
    End Sub

    Private Sub SEI_Click(sender As Object, e As EventArgs) Handles SEI.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://sei.tjrs.jus.br/sip/login.php?sigla_orgao_sistema=TJRS&sigla_sistema=SEI")
    End Sub

    Private Sub MaloteDigital_Click(sender As Object, e As EventArgs) Handles MaloteDigital.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.tjrs.gov.br/organizacional/login.jsf")
    End Sub

    Private Sub soeweb_Click(sender As Object, e As EventArgs) Handles soeweb.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.soe.rs.gov.br/soe/protegido/NSOEdefault.html")
    End Sub

    Private Sub mailadm_Click(sender As Object, e As EventArgs) Handles mailadm.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://webmail.tjrs.jus.br/owa/auth/logon.aspx?replaceCurrent=1&url=https%3a%2f%2fwebmail.tjrs.jus.br%2fecp%2f")
    End Sub

    Private Sub et1g_Click(sender As Object, e As EventArgs) Handles et1g.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://www.tjrs.gov.br/ethemis1g/res-plc/login/loginPlc.html")
    End Sub

    Private Sub GRP_Click(sender As Object, e As EventArgs) Handles GRP.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://grp.tjrs.jus.br/grp/home.faces")
    End Sub

    Private Sub SGE_Click(sender As Object, e As EventArgs) Handles SGE.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://sge.tjrs.gov.br/")
    End Sub

    Private Sub eproc_Click(sender As Object, e As EventArgs) Handles eproc.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://eproc1g.tjrs.jus.br/eproc/")
    End Sub

    Private Sub CNJcorporativo_Click(sender As Object, e As EventArgs) Handles CNJcorporativo.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.cnj.jus.br/corporativo/")
    End Sub

    Private Sub bnmp_Click(sender As Object, e As EventArgs) Handles bnmp.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://sso.cnj.jus.br/cas/login")
    End Sub

    Private Sub CNIB_Click(sender As Object, e As EventArgs) Handles CNIB.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.indisponibilidade.org.br/autenticacao/")
    End Sub

    Private Sub descobrirGG_Click(sender As Object, e As EventArgs) Handles descobrirGG.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://iis8-des-01/verpermissoes.php")
    End Sub

    Private Sub CRIrs_Click(sender As Object, e As EventArgs) Handles CRIrs.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.cri-rs.com.br/Conta/Login")
    End Sub

    Private Sub contasbloqueadas_Click(sender As Object, e As EventArgs) Handles contasbloqueadas.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://contasbloqueadas.tjrs.gov.br/")
    End Sub

    Private Sub metaframe_Click(sender As Object, e As EventArgs) Handles metaframe.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://metaframe.tjrs.jus.br/logon/LogonPoint/tmindex.html")
    End Sub

    Private Sub idmconsole_Click(sender As Object, e As EventArgs) Handles idmconsole.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://idm-prd-01.tjrs.gov.br:7001/console/login/LoginForm.jsp")
    End Sub

    Private Sub ADmigrator_Click(sender As Object, e As EventArgs) Handles ADmigrator.Click
        Process.Start("D:\migrator.bat")
    End Sub

    Private Sub pdfsam_Click(sender As Object, e As EventArgs) Handles pdfsam.Click
        Dim pdfsam() = Process.GetProcessesByName("javaw")
        For Each Process As Process In pdfsam
            Process.Kill()
        Next

        Process.Start("C:\Program Files (x86)\PDFsam Basic\pdfsam.exe")
    End Sub

    Private Sub vincularcalcp1g_Click(sender As Object, e As EventArgs) Handles vincularcalcp1g.Click
        Dim vinculacalcp() = Process.GetProcessesByName("VinculaUsuarioEquipe")
        For Each Process As Process In vinculacalcp
            Process.Kill()
        Next

        Process.Start("W:\Sistemas-EXE\Vinculação de Usuários CalcPro1G\VinculaUsuarioEquipe.exe")
    End Sub

    Private Sub TerminalProcergs_Click(sender As Object, e As EventArgs) Handles TerminalProcergs.Click
        Dim terminalprocergs() = Process.GetProcessesByName("pw3270")
        For Each Process As Process In terminalprocergs
            Process.Kill()
        Next

        Process.Start("D:\TJRS\PW3270\pw3270.exe")
    End Sub

    Private Sub skypeadm_Click(sender As Object, e As EventArgs) Handles skypeadm.Click
        Process.Start("C:\Program Files\Internet Explorer\iexplore.exe", "https://skp-drpool01webint.tjrs.jus.br/Cscp/#MainFrameViewModel%3DUsers%2CUsers%3DUserSearch")
    End Sub

    Private Sub sasv_Click(sender As Object, e As EventArgs) Handles sasv.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.tjrs.gov.br/sasv/")
    End Sub

    Private Sub msword_Click(sender As Object, e As EventArgs) Handles msword.Click
        Process.Start("C:\Program Files (x86)\Microsoft Office\Office16\WINWORD.EXE")
    End Sub

    Private Sub excel_Click(sender As Object, e As EventArgs) Handles excel.Click
        Process.Start("C:\Program Files (x86)\Microsoft Office\Office16\EXCEL.EXE")
    End Sub

    Private Sub outlook_Click(sender As Object, e As EventArgs) Handles outlook.Click
        Process.Start("C:\Program Files (x86)\Microsoft Office\Office16\OUTLOOK.EXE")
    End Sub

    Private Sub skype_Click(sender As Object, e As EventArgs) Handles skype.Click
        Process.Start("C:\Program Files (x86)\Microsoft Office\Office16\lync.exe")
    End Sub

    Private Sub bbb_Click(sender As Object, e As EventArgs) Handles bbb.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://bbb.tjrs.jus.br/")
    End Sub

    Private Sub FecharAD_Click(sender As Object, e As EventArgs) Handles FecharAD.Click
        Dim ad() = Process.GetProcessesByName("mmc")
        For Each Process As Process In ad
            Process.Kill()
        Next
    End Sub

    Private Sub LimparCPF_Click(sender As Object, e As EventArgs) Handles LimparCPF.Click
        Process.Start("powershell", "-File \\cpoatj02\di-provisionamento\ATALHOS\Scripts\clipboard.ps1")
    End Sub

    Private Sub AjusteSetorial_Click(sender As Object, e As EventArgs) Handles AjusteSetorial.Click
        Process.Start("powershell", "-File D:\PowerShell\ScriptFiles\setorialmailbox.ps1")
    End Sub

    Private Sub OficioEletronico_Click(sender As Object, e As EventArgs) Handles OficioEletronico.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://oficioeletronico.com.br/")
    End Sub



    ' Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "")
End Class
