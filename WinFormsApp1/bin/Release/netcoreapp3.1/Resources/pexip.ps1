#begin


    $email = Read-Host "Informar e-mail sem a termina��o @tjrs.jus.br "
    $domain = Read-Host "Informar dom�nio (1gint,1gpoa,2g)"
    
    function cadastrar{
    
    $codcomar = Read-Host "Informar c�digo da comarca"
    $codvara = Read-Host "Informar c�digo da vara"

    $mail = Get-ADUser $email -server $server -Properties *
    $group = Get-ADGroup -Identity GU_VMR_PEXIP_INFINTY -Server adpoa19.2g.tj.rs

    set-aduser $mail -server $server -replace @{extensionAttribute14="$codcomar";extensionAttribute15="$codvara"}
    Add-ADGroupMember $group -Members $mail

    Write-Host "Conta cadastrada com sucesso"
    
    Read-Host -Prompt "Pressione qualquer tecla para fechar"
    
    }

    function cadastrar1gpoa{
    
    $codvara = Read-Host "Informar c�digo da vara"

    $mail = Get-ADUser $email -server $server -Properties *
    $group = Get-ADGroup -Identity GU_VMR_PEXIP_INFINTY -Server adpoa19.2g.tj.rs

    set-aduser $mail -server $server -replace @{extensionAttribute14="$codcomar";extensionAttribute15="$codvara"}
    Add-ADGroupMember $group -Members $mail

    Write-Host "Conta cadastrada com sucesso"

    
    Read-Host -Prompt "Pressione qualquer tecla para fechar"

    }

    function cadastrar2g{
    
    $mail = Get-ADUser $email -server $server -Properties *
    $group = Get-ADGroup -Identity GU_VMR_PEXIP_INFINTY -Server adpoa19.2g.tj.rs
    
    Add-ADGroupMember $group -Members $mail
    Write-Host "Conta cadastrada com sucesso"

    
    Read-Host -Prompt "Pressione qualquer tecla para fechar"

    }

    switch ($domain)
    {
        1gint {
            $server = "adint24.1gint.tj.rs"
            cadastrar
                }

        1gpoa {
            $server = "adfct04.1gpoa.tj.rs"
            $codcomar = "1"
            cadastrar1gpoa
                }

        2g {
            $server = "adpoa20.2g.tj.rs"
            cadastrar2g
                }

    }



#end