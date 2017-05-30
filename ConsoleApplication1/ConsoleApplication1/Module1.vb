Module Module1

    Sub Main()
        Console.WriteLine("test")
        Console.ReadKey()

        '/////////////////////////////////////////////////////////////
        ' ファイルをコピーする
        '/////////////////////////////////////////////////////////////

        '"C:\test\1.txt"を"C:\test\2.txt"にコピーする
        'コピーするファイルが存在しない時は、FileNotFoundExceptionが発生
        'コピー先のフォルダが存在しない時は、DirectoryNotFoundExceptionが発生
        'コピー先のファイルがすでに存在している時などで、IOExceptionが発生
        'コピー先のファイルへのアクセスが拒否された時などで、
        '  UnauthorizedAccessExceptionが発生
        System.IO.File.Copy("C:\test\1.txt", "C:\test\2.txt")

        '第3項にTrueを指定すると、コピー先が存在している時、上書きする
        '上書きするファイルが読み取り専用などで上書きできない場合は、
        '  UnauthorizedAccessExceptionが発生
        System.IO.File.Copy("C:\test\1.txt", "C:\test\2.txt", True)

        '/////////////////////////////////////////////////////////////
        ' ファイルを移動する
        '/////////////////////////////////////////////////////////////

        '"C:\test\1.txt"を"C:\test\3.txt"に移動する
        '別のドライブ（ディスクボリューム）への移動も可能
        '移動元と移動先が同じでも、例外は発生しない
        '移動元のファイルが存在しない時は、FileNotFoundExceptionが発生
        '移動先のフォルダが存在しない時は、DirectoryNotFoundExceptionが発生
        '移動先のファイルがすでに存在している時などで、例外IOExceptionが発生
        '移動先のファイルへのアクセスが拒否された時などで、
        '  UnauthorizedAccessExceptionが発生
        System.IO.File.Move("C:\test\1.txt", "C:\test\3.txt")

        '/////////////////////////////////////////////////////////////
        ' ファイルを削除する
        '/////////////////////////////////////////////////////////////

        '"C:\test\3.txt"を削除する
        '指定したファイルが存在しなくても例外は発生しない
        '読み取り専用ファイルだと、例外UnauthorizedAccessExceptionが発生
        System.IO.File.Delete("C:\test\3.txt")
    End Sub

End Module
