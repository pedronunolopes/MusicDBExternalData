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

public class ActGetMusicStyleByArtist {

	/**
	 *
	 * @param inParamArtistId
	 * @param result.outParamArtistMusicStyle
	 **/
	public static ActGetMusicStyleByArtist mosGetMusicStyleByArtist(int inParamArtistId) {
		ActGetMusicStyleByArtist result = new ActGetMusicStyleByArtist();
		result.outParamArtistMusicStyle = new RLt_MDMusicStyleRecordList();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RLt_MDMusicStyleRecordList outParamArtistMusicStyle;

}
