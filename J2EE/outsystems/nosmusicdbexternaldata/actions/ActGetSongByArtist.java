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

public class ActGetSongByArtist {

	/**
	 *
	 * @param inParamArtistId
	 * @param result.outParamArtistSong
	 **/
	public static ActGetSongByArtist mosGetSongByArtist(int inParamArtistId) {
		ActGetSongByArtist result = new ActGetSongByArtist();
		result.outParamArtistSong = new RLt_MUSongRecordList();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RLt_MUSongRecordList outParamArtistSong;

}
