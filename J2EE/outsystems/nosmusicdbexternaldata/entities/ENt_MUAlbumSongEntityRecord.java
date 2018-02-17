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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_MUAlbumSong", key = "HSsjVWi7p0+6KokqNpjfKg", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_MUAlbumSong]", dbConnection = "")
public final class ENt_MUAlbumSongEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_MUAlbumSongEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdAlbumId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*dB2TDPdNGkubNJk+mFvKMg");
	private static final GlobalObjectKey IdSongId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*oaPOrRlUuka8dJYw8Ckr1w");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*mjEE6jZuLk6sWIYI1wrgQg");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*JrLpWPo8PUm3wk4Wiz8y5A");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "AlbumId", length=0, isAutonumber=false, isPrimaryKey=true, isEntityReference=true, isMandatory=true)
	private int _ssAlbumId;
	public int getSsAlbumId() {
		return _ssAlbumId;
	}
	public void setSsAlbumId(int value) {
		if ((_ssAlbumId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes = BitSetUtils.newInstance(4, true);
			_ssAlbumId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "SongId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private long _ssSongId;
	public long getSsSongId() {
		return _ssSongId;
	}
	public void setSsSongId(long value) {
		if ((_ssSongId != value) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssSongId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssInsertDate;
	public DateTime getSsInsertDate() {
		return _ssInsertDate;
	}
	public void setSsInsertDate(DateTime value) {
		if ((!_ssInsertDate.equals(value)) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssInsertDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssUpdateDate;
	public DateTime getSsUpdateDate() {
		return _ssUpdateDate;
	}
	public void setSsUpdateDate(DateTime value) {
		if ((!_ssUpdateDate.equals(value)) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
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
	public ENt_MUAlbumSongEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(4, true);
		OptimizedAttributes = BitSetUtils.newInstance(4, false);
		_ssAlbumId = 0;
		_ssSongId = 0L;
		_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_MUAlbumSongRecord toRecord() {
		try {
			return new RCt_MUAlbumSongRecord(this);
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
		setSsAlbumId(DataReaderUtils.readEntityReference(r, index++, "t_MUAlbumSong.AlbumId", 0));
		setSsSongId(DataReaderUtils.readEntityReferenceLongInteger(r, index++, "t_MUAlbumSong.SongId", 0L));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_MUAlbumSong.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_MUAlbumSong.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		ChangedAttributes = BitSetUtils.newInstance(4, false);
		OptimizedAttributes = BitSetUtils.newInstance(4, false);
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
	public void readIM(ENt_MUAlbumSongEntityRecord r) throws Exception {
		this.setSsAlbumId(r.getSsAlbumId());
		this.setSsSongId(r.getSsSongId());
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
		if ((obj == null) || !(obj instanceof ENt_MUAlbumSongEntityRecord)) {
			return false;
		}
		ENt_MUAlbumSongEntityRecord b = (ENt_MUAlbumSongEntityRecord) obj;
		if (this.getSsAlbumId() != b.getSsAlbumId()) return false;
		if (this.getSsSongId() != b.getSsSongId()) return false;
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
			return super.hashCode() ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
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
	public ENt_MUAlbumSongEntityRecord duplicate() throws Exception {
		ENt_MUAlbumSongEntityRecord t = new ENt_MUAlbumSongEntityRecord();
		t._ssAlbumId = this._ssAlbumId;
		t._ssSongId = this._ssSongId;
		t._ssInsertDate = this._ssInsertDate;
		t._ssUpdateDate = this._ssUpdateDate;
		t.ChangedAttributes = new BitSet(4);
		t.OptimizedAttributes = new BitSet(4);
		for (int i = 0; i < 4; i++) {
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".AlbumId")) VarValue.appendAttribute(recordElem, "AlbumId", Integer.valueOf(getSsAlbumId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "AlbumId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".SongId")) VarValue.appendAttribute(recordElem, "SongId", Long.valueOf(getSsSongId()), detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.appendOptimizedAttribute(recordElem, "SongId");
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
		if (head.equals("albumid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".AlbumId")) variable.setValue(getSsAlbumId()); else variable.setOptimized(true);
		} else if (head.equals("songid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".SongId")) variable.setValue(getSsSongId()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_MUAlbumSongEntityRecord t = (ENt_MUAlbumSongEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdAlbumId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdSongId)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdInsertDate)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdUpdateDate)) {
			return ChangedAttributes.get(3);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdAlbumId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdSongId)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdInsertDate)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdUpdateDate)) {
			return OptimizedAttributes.get(3);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdAlbumId)) {
			return getSsAlbumId();
		} else if (key.equals(IdSongId)) {
			return getSsSongId();
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
		ChangedAttributes = new BitSet(4);
		OptimizedAttributes = new BitSet(4);
		setSsAlbumId(((Integer) other.attributeGet(IdAlbumId)).intValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdAlbumId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdAlbumId));
		setSsSongId(((Long) other.attributeGet(IdSongId)).longValue());
		ChangedAttributes.set(1, other.changedAttributeGet(IdSongId));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdSongId));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(2, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(3, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdUpdateDate));
	}
}
