package outsystems.nosmusicdbexternaldata.actions;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.records.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.runtimepublic.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.log.*;
import java.math.BigDecimal;

public class ActGetArtistMusicStyle {

	/**
	 *
	 * @param inParamArtistId
	 * @param result.outParamArtistMusicStyles
	 **/
	public static ActGetArtistMusicStyle mosGetArtistMusicStyle(int inParamArtistId) {
		ActGetArtistMusicStyle result = new ActGetArtistMusicStyle();
		result.outParamArtistMusicStyles = new RLt_MUArtistMusicStyleRecordList();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RLt_MUArtistMusicStyleRecordList outParamArtistMusicStyles;
	public RLt_MUArtistMusicStyleRecordList outParamArtistMusicStyle;

}
