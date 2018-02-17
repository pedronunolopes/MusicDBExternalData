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


public final class ENt_MTMediaEntity {
	public static String localViewName(Integer tenant, String locale) {
		return viewName(null, locale);
	}
	public static String viewName(Integer tenant, String locale) {
		return "[dbo].[t_MTMedia]";
	}
	public static java.util.HashMap<String, String> attributesToDatabaseNamesMap() {
		return new java.util.HashMap<String, String>() {
			{
				put("mediaid", "MediaId"); put("filename", "FileName"); put("mimetype", "MimeType"); put("mediafiletypeid", "MediaFileTypeId"); put("filebinary", "FileBinary"); put("insertdate", "InsertDate"); put("updatedate", "UpdateDate"); 
			}
		};
	}
} // ENt_MTMediaEntity
