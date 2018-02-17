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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_SMArtistDataPoint", key = "ItWSFiRyykqtYZx2qDHWmg", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_SMArtistDataPoint]", dbConnection = "")
public final class ENt_SMArtistDataPointEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_SMArtistDataPointEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdDataPointId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*JR9XVW899Ea4DDjMHtPW3A");
	private static final GlobalObjectKey IdArtistId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*2rlCqOp3_UuV7VEo_nb2kA");
	private static final GlobalObjectKey IdSocialMediaId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*j6fyeh75x0+UXAYfhKwWxg");
	private static final GlobalObjectKey IdDataPointTypeId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*aoSLL1yS9E67XNKgKpgpsQ");
	private static final GlobalObjectKey IdDatapoint = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*qAyhF13rlESRD_e8LdpfxA");
	private static final GlobalObjectKey IdCountryId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*z+QYh_wcJkyNTvWE+_ibBQ");
	private static final GlobalObjectKey IdReferenceDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*3Ypwk4op9EedWZyAtk6RCg");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*m3ScJm5_DU6vYUWsOGbUwg");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*A7Q2+417f0OvdBbtH_t0xQ");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "DataPointId", length=0, isAutonumber=true, isPrimaryKey=true, isEntityReference=false, isMandatory=true)
	private long _ssDataPointId;
	public long getSsDataPointId() {
		return _ssDataPointId;
	}
	public void setSsDataPointId(long value) {
		if ((_ssDataPointId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes = BitSetUtils.newInstance(9, true);
			_ssDataPointId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ArtistId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssArtistId;
	public int getSsArtistId() {
		return _ssArtistId;
	}
	public void setSsArtistId(int value) {
		if ((_ssArtistId != value) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssArtistId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "SocialMediaId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssSocialMediaId;
	public int getSsSocialMediaId() {
		return _ssSocialMediaId;
	}
	public void setSsSocialMediaId(int value) {
		if ((_ssSocialMediaId != value) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssSocialMediaId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "DataPointTypeId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssDataPointTypeId;
	public int getSsDataPointTypeId() {
		return _ssDataPointTypeId;
	}
	public void setSsDataPointTypeId(int value) {
		if ((_ssDataPointTypeId != value) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
			_ssDataPointTypeId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Datapoint", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private long _ssDatapoint;
	public long getSsDatapoint() {
		return _ssDatapoint;
	}
	public void setSsDatapoint(long value) {
		if ((_ssDatapoint != value) || OptimizedAttributes.get(4)) {
			ChangedAttributes.set(4, true);
			_ssDatapoint = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "CountryId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=false)
	private int _ssCountryId;
	public int getSsCountryId() {
		return _ssCountryId;
	}
	public void setSsCountryId(int value) {
		if ((_ssCountryId != value) || OptimizedAttributes.get(5)) {
			ChangedAttributes.set(5, true);
			_ssCountryId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ReferenceDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private DateTime _ssReferenceDate;
	public DateTime getSsReferenceDate() {
		return _ssReferenceDate;
	}
	public void setSsReferenceDate(DateTime value) {
		if ((!_ssReferenceDate.equals(value)) || OptimizedAttributes.get(6)) {
			ChangedAttributes.set(6, true);
			_ssReferenceDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssInsertDate;
	public DateTime getSsInsertDate() {
		return _ssInsertDate;
	}
	public void setSsInsertDate(DateTime value) {
		if ((!_ssInsertDate.equals(value)) || OptimizedAttributes.get(7)) {
			ChangedAttributes.set(7, true);
			_ssInsertDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssUpdateDate;
	public DateTime getSsUpdateDate() {
		return _ssUpdateDate;
	}
	public void setSsUpdateDate(DateTime value) {
		if ((!_ssUpdateDate.equals(value)) || OptimizedAttributes.get(8)) {
			ChangedAttributes.set(8, true);
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
	public ENt_SMArtistDataPointEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(9, true);
		OptimizedAttributes = BitSetUtils.newInstance(9, false);
		_ssDataPointId = 0L;
		_ssArtistId = 0;
		_ssSocialMediaId = 0;
		_ssDataPointTypeId = 0;
		_ssDatapoint = 0L;
		_ssCountryId = 0;
		_ssReferenceDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_SMArtistDataPointRecord toRecord() {
		try {
			return new RCt_SMArtistDataPointRecord(this);
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
		setSsDataPointId(DataReaderUtils.readLongInteger(r, index++, "t_SMArtistDataPoint.DataPointId", 0L));
		setSsArtistId(DataReaderUtils.readEntityReference(r, index++, "t_SMArtistDataPoint.ArtistId", 0));
		setSsSocialMediaId(DataReaderUtils.readEntityReference(r, index++, "t_SMArtistDataPoint.SocialMediaId", 0));
		setSsDataPointTypeId(DataReaderUtils.readEntityReference(r, index++, "t_SMArtistDataPoint.DataPointTypeId", 0));
		setSsDatapoint(DataReaderUtils.readLongInteger(r, index++, "t_SMArtistDataPoint.Datapoint", 0L));
		setSsCountryId(DataReaderUtils.readEntityReference(r, index++, "t_SMArtistDataPoint.CountryId", 0));
		setSsReferenceDate(DataReaderUtils.readDate(r, index++, "t_SMArtistDataPoint.ReferenceDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_SMArtistDataPoint.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_SMArtistDataPoint.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		ChangedAttributes = BitSetUtils.newInstance(9, false);
		OptimizedAttributes = BitSetUtils.newInstance(9, false);
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
	public void readIM(ENt_SMArtistDataPointEntityRecord r) throws Exception {
		this.setSsDataPointId(r.getSsDataPointId());
		this.setSsArtistId(r.getSsArtistId());
		this.setSsSocialMediaId(r.getSsSocialMediaId());
		this.setSsDataPointTypeId(r.getSsDataPointTypeId());
		this.setSsDatapoint(r.getSsDatapoint());
		this.setSsCountryId(r.getSsCountryId());
		this.setSsReferenceDate(r.getSsReferenceDate());
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
		if ((obj == null) || !(obj instanceof ENt_SMArtistDataPointEntityRecord)) {
			return false;
		}
		ENt_SMArtistDataPointEntityRecord b = (ENt_SMArtistDataPointEntityRecord) obj;
		if (this.getSsDataPointId() != b.getSsDataPointId()) return false;
		if (this.getSsArtistId() != b.getSsArtistId()) return false;
		if (this.getSsSocialMediaId() != b.getSsSocialMediaId()) return false;
		if (this.getSsDataPointTypeId() != b.getSsDataPointTypeId()) return false;
		if (this.getSsDatapoint() != b.getSsDatapoint()) return false;
		if (this.getSsCountryId() != b.getSsCountryId()) return false;
		if (!this.getSsReferenceDate().equals(b.getSsReferenceDate())) return false;
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
			return super.hashCode() ^ getSsReferenceDate().hashCode() ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
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
	public ENt_SMArtistDataPointEntityRecord duplicate() throws Exception {
		ENt_SMArtistDataPointEntityRecord t = new ENt_SMArtistDataPointEntityRecord();
		t._ssDataPointId = this._ssDataPointId;
		t._ssArtistId = this._ssArtistId;
		t._ssSocialMediaId = this._ssSocialMediaId;
		t._ssDataPointTypeId = this._ssDataPointTypeId;
		t._ssDatapoint = this._ssDatapoint;
		t._ssCountryId = this._ssCountryId;
		t._ssReferenceDate = this._ssReferenceDate;
		t._ssInsertDate = this._ssInsertDate;
		t._ssUpdateDate = this._ssUpdateDate;
		t.ChangedAttributes = new BitSet(9);
		t.OptimizedAttributes = new BitSet(9);
		for (int i = 0; i < 9; i++) {
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".DataPointId")) VarValue.appendAttribute(recordElem, "DataPointId", Long.valueOf(getSsDataPointId()), detailLevel, TypeKind.LongInteger); else VarValue.appendOptimizedAttribute(recordElem, "DataPointId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".ArtistId")) VarValue.appendAttribute(recordElem, "ArtistId", Integer.valueOf(getSsArtistId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "ArtistId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".SocialMediaId")) VarValue.appendAttribute(recordElem, "SocialMediaId", Integer.valueOf(getSsSocialMediaId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "SocialMediaId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".DataPointTypeId")) VarValue.appendAttribute(recordElem, "DataPointTypeId", Integer.valueOf(getSsDataPointTypeId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "DataPointTypeId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Datapoint")) VarValue.appendAttribute(recordElem, "Datapoint", Long.valueOf(getSsDatapoint()), detailLevel, TypeKind.LongInteger); else VarValue.appendOptimizedAttribute(recordElem, "Datapoint");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".CountryId")) VarValue.appendAttribute(recordElem, "CountryId", Integer.valueOf(getSsCountryId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "CountryId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".ReferenceDate")) VarValue.appendAttribute(recordElem, "ReferenceDate", getSsReferenceDate(), detailLevel, TypeKind.Date); else VarValue.appendOptimizedAttribute(recordElem, "ReferenceDate");
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
		if (head.equals("datapointid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".DataPointId")) variable.setValue(getSsDataPointId()); else variable.setOptimized(true);
		} else if (head.equals("artistid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".ArtistId")) variable.setValue(getSsArtistId()); else variable.setOptimized(true);
		} else if (head.equals("socialmediaid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".SocialMediaId")) variable.setValue(getSsSocialMediaId()); else variable.setOptimized(true);
		} else if (head.equals("datapointtypeid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".DataPointTypeId")) variable.setValue(getSsDataPointTypeId()); else variable.setOptimized(true);
		} else if (head.equals("datapoint")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Datapoint")) variable.setValue(getSsDatapoint()); else variable.setOptimized(true);
		} else if (head.equals("countryid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".CountryId")) variable.setValue(getSsCountryId()); else variable.setOptimized(true);
		} else if (head.equals("referencedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".ReferenceDate")) variable.setValue(getSsReferenceDate()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_SMArtistDataPointEntityRecord t = (ENt_SMArtistDataPointEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdDataPointId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdArtistId)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdSocialMediaId)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdDataPointTypeId)) {
			return ChangedAttributes.get(3);
		} else if (key.equals(IdDatapoint)) {
			return ChangedAttributes.get(4);
		} else if (key.equals(IdCountryId)) {
			return ChangedAttributes.get(5);
		} else if (key.equals(IdReferenceDate)) {
			return ChangedAttributes.get(6);
		} else if (key.equals(IdInsertDate)) {
			return ChangedAttributes.get(7);
		} else if (key.equals(IdUpdateDate)) {
			return ChangedAttributes.get(8);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdDataPointId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdArtistId)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdSocialMediaId)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdDataPointTypeId)) {
			return OptimizedAttributes.get(3);
		} else if (key.equals(IdDatapoint)) {
			return OptimizedAttributes.get(4);
		} else if (key.equals(IdCountryId)) {
			return OptimizedAttributes.get(5);
		} else if (key.equals(IdReferenceDate)) {
			return OptimizedAttributes.get(6);
		} else if (key.equals(IdInsertDate)) {
			return OptimizedAttributes.get(7);
		} else if (key.equals(IdUpdateDate)) {
			return OptimizedAttributes.get(8);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdDataPointId)) {
			return getSsDataPointId();
		} else if (key.equals(IdArtistId)) {
			return getSsArtistId();
		} else if (key.equals(IdSocialMediaId)) {
			return getSsSocialMediaId();
		} else if (key.equals(IdDataPointTypeId)) {
			return getSsDataPointTypeId();
		} else if (key.equals(IdDatapoint)) {
			return getSsDatapoint();
		} else if (key.equals(IdCountryId)) {
			return getSsCountryId();
		} else if (key.equals(IdReferenceDate)) {
			return getSsReferenceDate();
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
		ChangedAttributes = new BitSet(9);
		OptimizedAttributes = new BitSet(9);
		setSsDataPointId(((Long) other.attributeGet(IdDataPointId)).longValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdDataPointId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdDataPointId));
		setSsArtistId(((Integer) other.attributeGet(IdArtistId)).intValue());
		ChangedAttributes.set(1, other.changedAttributeGet(IdArtistId));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdArtistId));
		setSsSocialMediaId(((Integer) other.attributeGet(IdSocialMediaId)).intValue());
		ChangedAttributes.set(2, other.changedAttributeGet(IdSocialMediaId));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdSocialMediaId));
		setSsDataPointTypeId(((Integer) other.attributeGet(IdDataPointTypeId)).intValue());
		ChangedAttributes.set(3, other.changedAttributeGet(IdDataPointTypeId));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdDataPointTypeId));
		setSsDatapoint(((Long) other.attributeGet(IdDatapoint)).longValue());
		ChangedAttributes.set(4, other.changedAttributeGet(IdDatapoint));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdDatapoint));
		setSsCountryId(((Integer) other.attributeGet(IdCountryId)).intValue());
		ChangedAttributes.set(5, other.changedAttributeGet(IdCountryId));
		OptimizedAttributes.set(5, other.optimizedAttributeGet(IdCountryId));
		setSsReferenceDate((DateTime) other.attributeGet(IdReferenceDate));
		ChangedAttributes.set(6, other.changedAttributeGet(IdReferenceDate));
		OptimizedAttributes.set(6, other.optimizedAttributeGet(IdReferenceDate));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(7, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(7, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(8, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(8, other.optimizedAttributeGet(IdUpdateDate));
	}
}
