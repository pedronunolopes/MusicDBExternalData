using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OutSystems.NssMusicDBExternalData;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        RLt_MDMusicStyleRecordList rLt_MDMusicStyleRecordList = new RLt_MDMusicStyleRecordList();
        CssMusicDBExternalData cssMusicDBExternal = new CssMusicDBExternalData();
        RCt_SMArtistDataPointRecord sMArtistDataPointRecord;

        //cssMusicDBExternal.MssGetMusicStyleByArtist(1, out rLt_MDMusicStyleRecordList);

        cssMusicDBExternal.MssGetSocialMediaDataPointByArtist(1, 1, 2, -1, out sMArtistDataPointRecord);
    }
}