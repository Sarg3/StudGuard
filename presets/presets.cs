function StudGuard_loadFilePath(%path)
{
        if(strPos(%path,"./presets/*") <= 0)
                %path = %path @ "*";

        %filePath = filePath(%path);

        for(%file = findFirstFile(%path); %file !$= ""; %file = findNextFile(%path))
        {
                %fileExt = fileExt(%file);
                if(%fileExt !$= ".cs")
                        continue;

                exec(%file);
        }
}
