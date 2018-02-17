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

public class ActGetAlbumByArtist {

	/**
	 *
	 * @param inParamArtistId
	 * @param result.outParamArtistAlbum
	 **/
	public static ActGetAlbumByArtist mosGetAlbumByArtist(int inParamArtistId) {
		ActGetAlbumByArtist result = new ActGetAlbumByArtist();
		result.outParamArtistAlbum = new RLt_MUAlbumRecordList();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RLt_MUAlbumRecordList outParamArtistAlbum;

}
