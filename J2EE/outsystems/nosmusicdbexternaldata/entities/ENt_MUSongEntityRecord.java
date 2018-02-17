package outsystems.nosmusicdbexternaldata.entities;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_MUSong", key = "92B3GX62v02k1cgutB_e7w", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_MUSong]", dbConnection = "")
public final class ENt_MUSongEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_MUSongEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdSongId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*bxioCvsWKU6mu_MDZanNag");
	private static final GlobalObjectKey IdName = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*I7Li7pV6kkO0Cn1bVqKaCA");
	private static final GlobalObjectKey IdLength = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*WGD3DAcnA06_yUF2RQSJVg");
	private static final GlobalObjectKey IdReleaseDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*p1Ovz87_R0yhLzahKKd3EQ");
	private static final GlobalObjectKey IdWeeksInCharts = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*BCSeCGyQl0ewGR6HY38h+w");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*30fSvwcbgUmy9b2NEQ32SQ");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*7VSEc6cHPkC6FLrfk0xxvA");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "SongId", length=0, isAutonumber=true, isPrimaryKey=true, isEntityReference=false, isMandatory=true)
	private long _ssSongId;
	public long getSsSongId() {
		return _ssSongId;
	}
	public void setSsSongId(long value) {
		if ((_ssSongId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes = BitSetUtils.newInstance(7, true);
			_ssSongId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Name", length=500, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssName;
	public String getSsName() {
		return _ssName;
	}
	public void setSsName(String value) {
		if ((!_ssName.equals(value)) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssName = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Length", length=17, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssLength;
	public String getSsLength() {
		return _ssLength;
	}
	public void setSsLength(String value) {
		if ((!_ssLength.equals(value)) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssLength = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ReleaseDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private DateTime _ssReleaseDate;
	public DateTime getSsReleaseDate() {
		return _ssReleaseDate;
	}
	public void setSsReleaseDate(DateTime value) {
		if ((!_ssReleaseDate.equals(value)) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
			_ssReleaseDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "WeeksInCharts", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private int _ssWeeksInCharts;
	public int getSsWeeksInCharts() {
		return _ssWeeksInCharts;
	}
	public void setSsWeeksInCharts(int value) {
		if ((_ssWeeksInCharts != value) || OptimizedAttributes.get(4)) {
			ChangedAttributes.set(4, true);
			_ssWeeksInCharts = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssInsertDate;
	public DateTime getSsInsertDate() {
		return _ssInsertDate;
	}
	public void setSsInsertDate(DateTime value) {
		if ((!_ssInsertDate.equals(value)) || OptimizedAttributes.get(5)) {
			ChangedAttributes.set(5, true);
			_ssInsertDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssUpdateDate;
	public DateTime getSsUpdateDate() {
		return _ssUpdateDate;
	}
	public void setSsUpdateDate(DateTime value) {
		if ((!_ssUpdateDate.equals(value)) || OptimizedAttributes.get(6)) {
			ChangedAttributes.set(6, true);
			_ssUpdateDate = value;
		}
	}


	public BitSet ChangedAttributes;
	public BitSet getChangedAttributes() {
		return ChangedAttributes;
	}

	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public ENt_MUSongEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(7, true);
		OptimizedAttributes = BitSetUtils.newInstance(7, false);
		_ssSongId = 0L;
		_ssName = "";
		_ssLength = "";
		_ssReleaseDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssWeeksInCharts = 0;
		_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_MUSongRecord toRecord() {
		try {
			return new RCt_MUSongRecord(this);
		} catch (Exception e) {
			return WrappedException.wrapExceptionIfNeeded(e);
		}
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[0];
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
		} else {
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[0];
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		setSsSongId(DataReaderUtils.readLongInteger(r, index++, "t_MUSong.SongId", 0L));
		setSsName(DataReaderUtils.readText(r, index++, "t_MUSong.Name", ""));
		setSsLength(DataReaderUtils.readText(r, index++, "t_MUSong.Length", ""));
		setSsReleaseDate(DataReaderUtils.readDate(r, index++, "t_MUSong.ReleaseDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsWeeksInCharts(DataReaderUtils.readInteger(r, index++, "t_MUSong.WeeksInCharts", 0));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_MUSong.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_MUSong.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		ChangedAttributes = BitSetUtils.newInstance(7, false);
		OptimizedAttributes = BitSetUtils.newInstance(7, false);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(ENt_MUSongEntityRecord r) throws Exception {
		this.setSsSongId(r.getSsSongId());
		this.setSsName(r.getSsName());
		this.setSsLength(r.getSsLength());
		this.setSsReleaseDate(r.getSsReleaseDate());
		this.setSsWeeksInCharts(r.getSsWeeksInCharts());
		this.setSsInsertDate(r.getSsInsertDate());
		this.setSsUpdateDate(r.getSsUpdateDate());
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof ENt_MUSongEntityRecord)) {
			return false;
		}
		ENt_MUSongEntityRecord b = (ENt_MUSongEntityRecord) obj;
		if (this.getSsSongId() != b.getSsSongId()) return false;
		if (!this.getSsName().equals(b.getSsName())) return false;
		if (!this.getSsLength().equals(b.getSsLength())) return false;
		if (!this.getSsReleaseDate().equals(b.getSsReleaseDate())) return false;
		if (this.getSsWeeksInCharts() != b.getSsWeeksInCharts()) return false;
		if (!this.getSsInsertDate().equals(b.getSsInsertDate())) return false;
		if (!this.getSsUpdateDate().equals(b.getSsUpdateDate())) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ getSsName().hashCode() ^ getSsLength().hashCode() ^ getSsReleaseDate().hashCode() ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public ENt_MUSongEntityRecord duplicate() throws Exception {
		ENt_MUSongEntityRecord t = new ENt_MUSongEntityRecord();
		t._ssSongId = this._ssSongId;
		t._ssName = this._ssName;
		t._ssLength = this._ssLength;
		t._ssReleaseDate = this._ssReleaseDate;
		t._ssWeeksInCharts = this._ssWeeksInCharts;
		t._ssInsertDate = this._ssInsertDate;
		t._ssUpdateDate = this._ssUpdateDate;
		t.ChangedAttributes = new BitSet(7);
		t.OptimizedAttributes = new BitSet(7);
		for (int i = 0; i < 7; i++) {
			t.ChangedAttributes.set(i, ChangedAttributes.get(i));
			t.OptimizedAttributes.set(i, OptimizedAttributes.get(i));
		}
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Entity");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
			fieldName = fieldName.toLowerCase();
		}
		if (detailLevel > 0) {
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".SongId")) VarValue.appendAttribute(recordElem, "SongId", Long.valueOf(getSsSongId()), detailLevel, TypeKind.LongInteger); else VarValue.appendOptimizedAttribute(recordElem, "SongId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Name")) VarValue.appendAttribute(recordElem, "Name", getSsName(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Name");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Length")) VarValue.appendAttribute(recordElem, "Length", getSsLength(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Length");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".ReleaseDate")) VarValue.appendAttribute(recordElem, "ReleaseDate", getSsReleaseDate(), detailLevel, TypeKind.Date); else VarValue.appendOptimizedAttribute(recordElem, "ReleaseDate");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".WeeksInCharts")) VarValue.appendAttribute(recordElem, "WeeksInCharts", Integer.valueOf(getSsWeeksInCharts()), detailLevel, TypeKind.Integer); else VarValue.appendOptimizedAttribute(recordElem, "WeeksInCharts");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.appendAttribute(recordElem, "InsertDate", getSsInsertDate(), detailLevel, TypeKind.DateTime); else VarValue.appendOptimizedAttribute(recordElem, "InsertDate");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.appendAttribute(recordElem, "UpdateDate", getSsUpdateDate(), detailLevel, TypeKind.DateTime); else VarValue.appendOptimizedAttribute(recordElem, "UpdateDate");
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("songid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".SongId")) variable.setValue(getSsSongId()); else variable.setOptimized(true);
		} else if (head.equals("name")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Name")) variable.setValue(getSsName()); else variable.setOptimized(true);
		} else if (head.equals("length")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Length")) variable.setValue(getSsLength()); else variable.setOptimized(true);
		} else if (head.equals("releasedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".ReleaseDate")) variable.setValue(getSsReleaseDate()); else variable.setOptimized(true);
		} else if (head.equals("weeksincharts")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".WeeksInCharts")) variable.setValue(getSsWeeksInCharts()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_MUSongEntityRecord t = (ENt_MUSongEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdSongId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdName)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdLength)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdReleaseDate)) {
			return ChangedAttributes.get(3);
		} else if (key.equals(IdWeeksInCharts)) {
			return ChangedAttributes.get(4);
		} else if (key.equals(IdInsertDate)) {
			return ChangedAttributes.get(5);
		} else if (key.equals(IdUpdateDate)) {
			return ChangedAttributes.get(6);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdSongId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdName)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdLength)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdReleaseDate)) {
			return OptimizedAttributes.get(3);
		} else if (key.equals(IdWeeksInCharts)) {
			return OptimizedAttributes.get(4);
		} else if (key.equals(IdInsertDate)) {
			return OptimizedAttributes.get(5);
		} else if (key.equals(IdUpdateDate)) {
			return OptimizedAttributes.get(6);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdSongId)) {
			return getSsSongId();
		} else if (key.equals(IdName)) {
			return getSsName();
		} else if (key.equals(IdLength)) {
			return getSsLength();
		} else if (key.equals(IdReleaseDate)) {
			return getSsReleaseDate();
		} else if (key.equals(IdWeeksInCharts)) {
			return getSsWeeksInCharts();
		} else if (key.equals(IdInsertDate)) {
			return getSsInsertDate();
		} else if (key.equals(IdUpdateDate)) {
			return getSsUpdateDate();
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ChangedAttributes = new BitSet(7);
		OptimizedAttributes = new BitSet(7);
		setSsSongId(((Long) other.attributeGet(IdSongId)).longValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdSongId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdSongId));
		setSsName((String) other.attributeGet(IdName));
		ChangedAttributes.set(1, other.changedAttributeGet(IdName));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdName));
		setSsLength((String) other.attributeGet(IdLength));
		ChangedAttributes.set(2, other.changedAttributeGet(IdLength));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdLength));
		setSsReleaseDate((DateTime) other.attributeGet(IdReleaseDate));
		ChangedAttributes.set(3, other.changedAttributeGet(IdReleaseDate));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdReleaseDate));
		setSsWeeksInCharts(((Integer) other.attributeGet(IdWeeksInCharts)).intValue());
		ChangedAttributes.set(4, other.changedAttributeGet(IdWeeksInCharts));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdWeeksInCharts));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(5, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(5, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(6, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(6, other.optimizedAttributeGet(IdUpdateDate));
	}
}
