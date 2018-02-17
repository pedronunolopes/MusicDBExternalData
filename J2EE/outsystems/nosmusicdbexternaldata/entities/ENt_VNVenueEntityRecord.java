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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_VNVenue", key = "b_trf52gz0ikNs7_GYS7Ww", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_VNVenue]", dbConnection = "")
public final class ENt_VNVenueEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_VNVenueEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdVenueId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*fCFHYMIWJ0+9voesc+M7Mg");
	private static final GlobalObjectKey IdName = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*v0UyGCkZ4kKTg4ijlXzraA");
	private static final GlobalObjectKey IdDescription = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*+7pxIfkq+UGlVRhEvLvtsg");
	private static final GlobalObjectKey IdCountryId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*T3Q_JAsYcEO3czLS7VlajA");
	private static final GlobalObjectKey IdCity = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*8JIGuIMzDUWWwwAVaYKduw");
	private static final GlobalObjectKey IdAddress1 = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*KYABMwNx_0Gf60SZDg_QnA");
	private static final GlobalObjectKey IdAddress2 = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*Q_j8BzqHfU29hHd4AXYjzA");
	private static final GlobalObjectKey IdLatitude = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*_pQwralPikS5jbEHtKmjSw");
	private static final GlobalObjectKey IdLongitude = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*zlROBmGeOEC_jC9hhfMQPg");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*X_F8zrG0_UiYTMNLW01knw");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*iMSgNO8QBEagvT4Q+eRdRA");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "VenueId", length=0, isAutonumber=true, isPrimaryKey=true, isEntityReference=false, isMandatory=true)
	private long _ssVenueId;
	public long getSsVenueId() {
		return _ssVenueId;
	}
	public void setSsVenueId(long value) {
		if ((_ssVenueId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes = BitSetUtils.newInstance(11, true);
			_ssVenueId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Name", length=100, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
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

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Description", length=500, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssDescription;
	public String getSsDescription() {
		return _ssDescription;
	}
	public void setSsDescription(String value) {
		if ((!_ssDescription.equals(value)) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssDescription = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "CountryId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=false)
	private int _ssCountryId;
	public int getSsCountryId() {
		return _ssCountryId;
	}
	public void setSsCountryId(int value) {
		if ((_ssCountryId != value) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
			_ssCountryId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "City", length=50, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssCity;
	public String getSsCity() {
		return _ssCity;
	}
	public void setSsCity(String value) {
		if ((!_ssCity.equals(value)) || OptimizedAttributes.get(4)) {
			ChangedAttributes.set(4, true);
			_ssCity = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Address1", length=200, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssAddress1;
	public String getSsAddress1() {
		return _ssAddress1;
	}
	public void setSsAddress1(String value) {
		if ((!_ssAddress1.equals(value)) || OptimizedAttributes.get(5)) {
			ChangedAttributes.set(5, true);
			_ssAddress1 = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Address2", length=200, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssAddress2;
	public String getSsAddress2() {
		return _ssAddress2;
	}
	public void setSsAddress2(String value) {
		if ((!_ssAddress2.equals(value)) || OptimizedAttributes.get(6)) {
			ChangedAttributes.set(6, true);
			_ssAddress2 = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Latitude", length=10, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private BigDecimal _ssLatitude;
	public BigDecimal getSsLatitude() {
		return _ssLatitude;
	}
	public void setSsLatitude(BigDecimal value) {
		if (DecimalUtils.different(_ssLatitude, value) || OptimizedAttributes.get(7)) {
			ChangedAttributes.set(7, true);
			_ssLatitude = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Longitude", length=10, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private BigDecimal _ssLongitude;
	public BigDecimal getSsLongitude() {
		return _ssLongitude;
	}
	public void setSsLongitude(BigDecimal value) {
		if (DecimalUtils.different(_ssLongitude, value) || OptimizedAttributes.get(8)) {
			ChangedAttributes.set(8, true);
			_ssLongitude = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private DateTime _ssInsertDate;
	public DateTime getSsInsertDate() {
		return _ssInsertDate;
	}
	public void setSsInsertDate(DateTime value) {
		if ((!_ssInsertDate.equals(value)) || OptimizedAttributes.get(9)) {
			ChangedAttributes.set(9, true);
			_ssInsertDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private DateTime _ssUpdateDate;
	public DateTime getSsUpdateDate() {
		return _ssUpdateDate;
	}
	public void setSsUpdateDate(DateTime value) {
		if ((!_ssUpdateDate.equals(value)) || OptimizedAttributes.get(10)) {
			ChangedAttributes.set(10, true);
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
	public ENt_VNVenueEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(11, true);
		OptimizedAttributes = BitSetUtils.newInstance(11, false);
		_ssVenueId = 0L;
		_ssName = "";
		_ssDescription = "";
		_ssCountryId = 0;
		_ssCity = "";
		_ssAddress1 = "";
		_ssAddress2 = "";
		_ssLatitude = BigDecimal.ZERO;
		_ssLongitude = BigDecimal.ZERO;
		_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_VNVenueRecord toRecord() {
		try {
			return new RCt_VNVenueRecord(this);
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
		setSsVenueId(DataReaderUtils.readLongInteger(r, index++, "t_VNVenue.VenueId", 0L));
		setSsName(DataReaderUtils.readText(r, index++, "t_VNVenue.Name", ""));
		setSsDescription(DataReaderUtils.readText(r, index++, "t_VNVenue.Description", ""));
		setSsCountryId(DataReaderUtils.readEntityReference(r, index++, "t_VNVenue.CountryId", 0));
		setSsCity(DataReaderUtils.readText(r, index++, "t_VNVenue.City", ""));
		setSsAddress1(DataReaderUtils.readText(r, index++, "t_VNVenue.Address1", ""));
		setSsAddress2(DataReaderUtils.readText(r, index++, "t_VNVenue.Address2", ""));
		setSsLatitude(DataReaderUtils.readDecimal(r, index++, "t_VNVenue.Latitude", BigDecimal.ZERO));
		setSsLongitude(DataReaderUtils.readDecimal(r, index++, "t_VNVenue.Longitude", BigDecimal.ZERO));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_VNVenue.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_VNVenue.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		ChangedAttributes = BitSetUtils.newInstance(11, false);
		OptimizedAttributes = BitSetUtils.newInstance(11, false);
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
	public void readIM(ENt_VNVenueEntityRecord r) throws Exception {
		this.setSsVenueId(r.getSsVenueId());
		this.setSsName(r.getSsName());
		this.setSsDescription(r.getSsDescription());
		this.setSsCountryId(r.getSsCountryId());
		this.setSsCity(r.getSsCity());
		this.setSsAddress1(r.getSsAddress1());
		this.setSsAddress2(r.getSsAddress2());
		this.setSsLatitude(r.getSsLatitude());
		this.setSsLongitude(r.getSsLongitude());
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
		if ((obj == null) || !(obj instanceof ENt_VNVenueEntityRecord)) {
			return false;
		}
		ENt_VNVenueEntityRecord b = (ENt_VNVenueEntityRecord) obj;
		if (this.getSsVenueId() != b.getSsVenueId()) return false;
		if (!this.getSsName().equals(b.getSsName())) return false;
		if (!this.getSsDescription().equals(b.getSsDescription())) return false;
		if (this.getSsCountryId() != b.getSsCountryId()) return false;
		if (!this.getSsCity().equals(b.getSsCity())) return false;
		if (!this.getSsAddress1().equals(b.getSsAddress1())) return false;
		if (!this.getSsAddress2().equals(b.getSsAddress2())) return false;
		if (!this.getSsLatitude().equals(b.getSsLatitude())) return false;
		if (!this.getSsLongitude().equals(b.getSsLongitude())) return false;
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
			return super.hashCode() ^ getSsName().hashCode() ^ getSsDescription().hashCode() ^ getSsCity().hashCode() ^ getSsAddress1().hashCode() ^ getSsAddress2().hashCode() ^ getSsLatitude().hashCode() ^ getSsLongitude().hashCode() ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
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
	public ENt_VNVenueEntityRecord duplicate() throws Exception {
		ENt_VNVenueEntityRecord t = new ENt_VNVenueEntityRecord();
		t._ssVenueId = this._ssVenueId;
		t._ssName = this._ssName;
		t._ssDescription = this._ssDescription;
		t._ssCountryId = this._ssCountryId;
		t._ssCity = this._ssCity;
		t._ssAddress1 = this._ssAddress1;
		t._ssAddress2 = this._ssAddress2;
		t._ssLatitude = this._ssLatitude;
		t._ssLongitude = this._ssLongitude;
		t._ssInsertDate = this._ssInsertDate;
		t._ssUpdateDate = this._ssUpdateDate;
		t.ChangedAttributes = new BitSet(11);
		t.OptimizedAttributes = new BitSet(11);
		for (int i = 0; i < 11; i++) {
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".VenueId")) VarValue.appendAttribute(recordElem, "VenueId", Long.valueOf(getSsVenueId()), detailLevel, TypeKind.LongInteger); else VarValue.appendOptimizedAttribute(recordElem, "VenueId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Name")) VarValue.appendAttribute(recordElem, "Name", getSsName(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Name");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Description")) VarValue.appendAttribute(recordElem, "Description", getSsDescription(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Description");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".CountryId")) VarValue.appendAttribute(recordElem, "CountryId", Integer.valueOf(getSsCountryId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "CountryId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".City")) VarValue.appendAttribute(recordElem, "City", getSsCity(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "City");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Address1")) VarValue.appendAttribute(recordElem, "Address1", getSsAddress1(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Address1");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Address2")) VarValue.appendAttribute(recordElem, "Address2", getSsAddress2(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Address2");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Latitude")) VarValue.appendAttribute(recordElem, "Latitude", getSsLatitude(), detailLevel, TypeKind.Decimal); else VarValue.appendOptimizedAttribute(recordElem, "Latitude");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Longitude")) VarValue.appendAttribute(recordElem, "Longitude", getSsLongitude(), detailLevel, TypeKind.Decimal); else VarValue.appendOptimizedAttribute(recordElem, "Longitude");
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
		if (head.equals("venueid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".VenueId")) variable.setValue(getSsVenueId()); else variable.setOptimized(true);
		} else if (head.equals("name")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Name")) variable.setValue(getSsName()); else variable.setOptimized(true);
		} else if (head.equals("description")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Description")) variable.setValue(getSsDescription()); else variable.setOptimized(true);
		} else if (head.equals("countryid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".CountryId")) variable.setValue(getSsCountryId()); else variable.setOptimized(true);
		} else if (head.equals("city")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".City")) variable.setValue(getSsCity()); else variable.setOptimized(true);
		} else if (head.equals("address1")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Address1")) variable.setValue(getSsAddress1()); else variable.setOptimized(true);
		} else if (head.equals("address2")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Address2")) variable.setValue(getSsAddress2()); else variable.setOptimized(true);
		} else if (head.equals("latitude")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Latitude")) variable.setValue(getSsLatitude()); else variable.setOptimized(true);
		} else if (head.equals("longitude")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Longitude")) variable.setValue(getSsLongitude()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_VNVenueEntityRecord t = (ENt_VNVenueEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdVenueId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdName)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdDescription)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdCountryId)) {
			return ChangedAttributes.get(3);
		} else if (key.equals(IdCity)) {
			return ChangedAttributes.get(4);
		} else if (key.equals(IdAddress1)) {
			return ChangedAttributes.get(5);
		} else if (key.equals(IdAddress2)) {
			return ChangedAttributes.get(6);
		} else if (key.equals(IdLatitude)) {
			return ChangedAttributes.get(7);
		} else if (key.equals(IdLongitude)) {
			return ChangedAttributes.get(8);
		} else if (key.equals(IdInsertDate)) {
			return ChangedAttributes.get(9);
		} else if (key.equals(IdUpdateDate)) {
			return ChangedAttributes.get(10);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdVenueId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdName)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdDescription)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdCountryId)) {
			return OptimizedAttributes.get(3);
		} else if (key.equals(IdCity)) {
			return OptimizedAttributes.get(4);
		} else if (key.equals(IdAddress1)) {
			return OptimizedAttributes.get(5);
		} else if (key.equals(IdAddress2)) {
			return OptimizedAttributes.get(6);
		} else if (key.equals(IdLatitude)) {
			return OptimizedAttributes.get(7);
		} else if (key.equals(IdLongitude)) {
			return OptimizedAttributes.get(8);
		} else if (key.equals(IdInsertDate)) {
			return OptimizedAttributes.get(9);
		} else if (key.equals(IdUpdateDate)) {
			return OptimizedAttributes.get(10);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdVenueId)) {
			return getSsVenueId();
		} else if (key.equals(IdName)) {
			return getSsName();
		} else if (key.equals(IdDescription)) {
			return getSsDescription();
		} else if (key.equals(IdCountryId)) {
			return getSsCountryId();
		} else if (key.equals(IdCity)) {
			return getSsCity();
		} else if (key.equals(IdAddress1)) {
			return getSsAddress1();
		} else if (key.equals(IdAddress2)) {
			return getSsAddress2();
		} else if (key.equals(IdLatitude)) {
			return getSsLatitude();
		} else if (key.equals(IdLongitude)) {
			return getSsLongitude();
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
		ChangedAttributes = new BitSet(11);
		OptimizedAttributes = new BitSet(11);
		setSsVenueId(((Long) other.attributeGet(IdVenueId)).longValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdVenueId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdVenueId));
		setSsName((String) other.attributeGet(IdName));
		ChangedAttributes.set(1, other.changedAttributeGet(IdName));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdName));
		setSsDescription((String) other.attributeGet(IdDescription));
		ChangedAttributes.set(2, other.changedAttributeGet(IdDescription));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdDescription));
		setSsCountryId(((Integer) other.attributeGet(IdCountryId)).intValue());
		ChangedAttributes.set(3, other.changedAttributeGet(IdCountryId));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdCountryId));
		setSsCity((String) other.attributeGet(IdCity));
		ChangedAttributes.set(4, other.changedAttributeGet(IdCity));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdCity));
		setSsAddress1((String) other.attributeGet(IdAddress1));
		ChangedAttributes.set(5, other.changedAttributeGet(IdAddress1));
		OptimizedAttributes.set(5, other.optimizedAttributeGet(IdAddress1));
		setSsAddress2((String) other.attributeGet(IdAddress2));
		ChangedAttributes.set(6, other.changedAttributeGet(IdAddress2));
		OptimizedAttributes.set(6, other.optimizedAttributeGet(IdAddress2));
		setSsLatitude((BigDecimal) other.attributeGet(IdLatitude));
		ChangedAttributes.set(7, other.changedAttributeGet(IdLatitude));
		OptimizedAttributes.set(7, other.optimizedAttributeGet(IdLatitude));
		setSsLongitude((BigDecimal) other.attributeGet(IdLongitude));
		ChangedAttributes.set(8, other.changedAttributeGet(IdLongitude));
		OptimizedAttributes.set(8, other.optimizedAttributeGet(IdLongitude));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(9, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(9, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(10, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(10, other.optimizedAttributeGet(IdUpdateDate));
	}
}
