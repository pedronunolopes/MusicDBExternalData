package outsystems.nosmusicdbexternaldata.entities;

import java.sql.*;
import java.lang.Number;
import java.math.BigDecimal;
import java.util.BitSet;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;


public final class ENt_MUArtistSocialMediaEntity {
	public static String localViewName(Integer tenant, String locale) {
		return viewName(null, locale);
	}
	public static String viewName(Integer tenant, String locale) {
		return "[dbo].[t_MUArtistSocialMedia]";
	}
	public static java.util.HashMap<String, String> attributesToDatabaseNamesMap() {
		return new java.util.HashMap<String, String>() {
			{
				put("artistid", "ArtistId"); put("socialmediaid", "SocialMediaId"); put("link", "Link"); put("insertdate", "InsertDate"); put("updatedate", "UpdateDate"); 
			}
		};
	}
} // ENt_MUArtistSocialMediaEntity
