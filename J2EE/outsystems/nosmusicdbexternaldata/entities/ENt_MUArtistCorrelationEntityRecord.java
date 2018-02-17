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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_MUArtistCorrelation", key = "zcm2usXe90upFf4XTxWCHA", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_MUArtistCorrelation]", dbConnection = "")
public final class ENt_MUArtistCorrelationEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_MUArtistCorrelationEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdArtistId1 = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*AJjBE9SENUSnxRwsWwciow");
	private static final GlobalObjectKey IdArtistId2 = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*XBf1gOnnWU6SUmMfzulofw");
	private static final GlobalObjectKey IdCorrelation = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*JSPomWr3iUSA0sj8UYZXjQ");
	private static final GlobalObjectKey IdSocialMediaId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*wCt75IMv3ku7PBvtTxNpXQ");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*9Jy_vLpJ6kKyRoL+VhlSbA");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*y8qQIW14ZE2mCvIIwS9NLw");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ArtistId1", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssArtistId1;
	public int getSsArtistId1() {
		return _ssArtistId1;
	}
	public void setSsArtistId1(int value) {
		if ((_ssArtistId1 != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes.set(0, true);
			_ssArtistId1 = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ArtistId2", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssArtistId2;
	public int getSsArtistId2() {
		return _ssArtistId2;
	}
	public void setSsArtistId2(int value) {
		if ((_ssArtistId2 != value) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssArtistId2 = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Correlation", length=18, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private BigDecimal _ssCorrelation;
	public BigDecimal getSsCorrelation() {
		return _ssCorrelation;
	}
	public void setSsCorrelation(BigDecimal value) {
		if (DecimalUtils.different(_ssCorrelation, value) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssCorrelation = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "SocialMediaId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private int _ssSocialMediaId;
	public int getSsSocialMediaId() {
		return _ssSocialMediaId;
	}
	public void setSsSocialMediaId(int value) {
		if ((_ssSocialMediaId != value) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
			_ssSocialMediaId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private DateTime _ssInsertDate;
	public DateTime getSsInsertDate() {
		return _ssInsertDate;
	}
	public void setSsInsertDate(DateTime value) {
		if ((!_ssInsertDate.equals(value)) || OptimizedAttributes.get(4)) {
			ChangedAttributes.set(4, true);
			_ssInsertDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private DateTime _ssUpdateDate;
	public DateTime getSsUpdateDate() {
		return _ssUpdateDate;
	}
	public void setSsUpdateDate(DateTime value) {
		if ((!_ssUpdateDate.equals(value)) || OptimizedAttributes.get(5)) {
			ChangedAttributes.set(5, true);
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
	public ENt_MUArtistCorrelationEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(6, true);
		OptimizedAttributes = BitSetUtils.newInstance(6, false);
		_ssArtistId1 = 0;
		_ssArtistId2 = 0;
		_ssCorrelation = BigDecimal.ZERO;
		_ssSocialMediaId = 0;
		_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_MUArtistCorrelationRecord toRecord() {
		try {
			return new RCt_MUArtistCorrelationRecord(this);
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
		setSsArtistId1(DataReaderUtils.readEntityReference(r, index++, "t_MUArtistCorrelation.ArtistId1", 0));
		setSsArtistId2(DataReaderUtils.readEntityReference(r, index++, "t_MUArtistCorrelation.ArtistId2", 0));
		setSsCorrelation(DataReaderUtils.readDecimal(r, index++, "t_MUArtistCorrelation.Correlation", BigDecimal.ZERO));
		setSsSocialMediaId(DataReaderUtils.readInteger(r, index++, "t_MUArtistCorrelation.SocialMediaId", 0));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_MUArtistCorrelation.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDate(r, index++, "t_MUArtistCorrelation.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		ChangedAttributes = BitSetUtils.newInstance(6, false);
		OptimizedAttributes = BitSetUtils.newInstance(6, false);
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
	public void readIM(ENt_MUArtistCorrelationEntityRecord r) throws Exception {
		this.setSsArtistId1(r.getSsArtistId1());
		this.setSsArtistId2(r.getSsArtistId2());
		this.setSsCorrelation(r.getSsCorrelation());
		this.setSsSocialMediaId(r.getSsSocialMediaId());
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
		if ((obj == null) || !(obj instanceof ENt_MUArtistCorrelationEntityRecord)) {
			return false;
		}
		ENt_MUArtistCorrelationEntityRecord b = (ENt_MUArtistCorrelationEntityRecord) obj;
		if (this.getSsArtistId1() != b.getSsArtistId1()) return false;
		if (this.getSsArtistId2() != b.getSsArtistId2()) return false;
		if (!this.getSsCorrelation().equals(b.getSsCorrelation())) return false;
		if (this.getSsSocialMediaId() != b.getSsSocialMediaId()) return false;
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
			return super.hashCode() ^ getSsCorrelation().hashCode() ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
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
	public ENt_MUArtistCorrelationEntityRecord duplicate() throws Exception {
		ENt_MUArtistCorrelationEntityRecord t = new ENt_MUArtistCorrelationEntityRecord();
		t._ssArtistId1 = this._ssArtistId1;
		t._ssArtistId2 = this._ssArtistId2;
		t._ssCorrelation = this._ssCorrelation;
		t._ssSocialMediaId = this._ssSocialMediaId;
		t._ssInsertDate = this._ssInsertDate;
		t._ssUpdateDate = this._ssUpdateDate;
		t.ChangedAttributes = new BitSet(6);
		t.OptimizedAttributes = new BitSet(6);
		for (int i = 0; i < 6; i++) {
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".ArtistId1")) VarValue.appendAttribute(recordElem, "ArtistId1", Integer.valueOf(getSsArtistId1()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "ArtistId1");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".ArtistId2")) VarValue.appendAttribute(recordElem, "ArtistId2", Integer.valueOf(getSsArtistId2()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "ArtistId2");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Correlation")) VarValue.appendAttribute(recordElem, "Correlation", getSsCorrelation(), detailLevel, TypeKind.Decimal); else VarValue.appendOptimizedAttribute(recordElem, "Correlation");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".SocialMediaId")) VarValue.appendAttribute(recordElem, "SocialMediaId", Integer.valueOf(getSsSocialMediaId()), detailLevel, TypeKind.Integer); else VarValue.appendOptimizedAttribute(recordElem, "SocialMediaId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.appendAttribute(recordElem, "InsertDate", getSsInsertDate(), detailLevel, TypeKind.DateTime); else VarValue.appendOptimizedAttribute(recordElem, "InsertDate");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.appendAttribute(recordElem, "UpdateDate", getSsUpdateDate(), detailLevel, TypeKind.Date); else VarValue.appendOptimizedAttribute(recordElem, "UpdateDate");
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("artistid1")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".ArtistId1")) variable.setValue(getSsArtistId1()); else variable.setOptimized(true);
		} else if (head.equals("artistid2")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".ArtistId2")) variable.setValue(getSsArtistId2()); else variable.setOptimized(true);
		} else if (head.equals("correlation")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Correlation")) variable.setValue(getSsCorrelation()); else variable.setOptimized(true);
		} else if (head.equals("socialmediaid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".SocialMediaId")) variable.setValue(getSsSocialMediaId()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_MUArtistCorrelationEntityRecord t = (ENt_MUArtistCorrelationEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdArtistId1)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdArtistId2)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdCorrelation)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdSocialMediaId)) {
			return ChangedAttributes.get(3);
		} else if (key.equals(IdInsertDate)) {
			return ChangedAttributes.get(4);
		} else if (key.equals(IdUpdateDate)) {
			return ChangedAttributes.get(5);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdArtistId1)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdArtistId2)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdCorrelation)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdSocialMediaId)) {
			return OptimizedAttributes.get(3);
		} else if (key.equals(IdInsertDate)) {
			return OptimizedAttributes.get(4);
		} else if (key.equals(IdUpdateDate)) {
			return OptimizedAttributes.get(5);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdArtistId1)) {
			return getSsArtistId1();
		} else if (key.equals(IdArtistId2)) {
			return getSsArtistId2();
		} else if (key.equals(IdCorrelation)) {
			return getSsCorrelation();
		} else if (key.equals(IdSocialMediaId)) {
			return getSsSocialMediaId();
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
		ChangedAttributes = new BitSet(6);
		OptimizedAttributes = new BitSet(6);
		setSsArtistId1(((Integer) other.attributeGet(IdArtistId1)).intValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdArtistId1));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdArtistId1));
		setSsArtistId2(((Integer) other.attributeGet(IdArtistId2)).intValue());
		ChangedAttributes.set(1, other.changedAttributeGet(IdArtistId2));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdArtistId2));
		setSsCorrelation((BigDecimal) other.attributeGet(IdCorrelation));
		ChangedAttributes.set(2, other.changedAttributeGet(IdCorrelation));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdCorrelation));
		setSsSocialMediaId(((Integer) other.attributeGet(IdSocialMediaId)).intValue());
		ChangedAttributes.set(3, other.changedAttributeGet(IdSocialMediaId));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdSocialMediaId));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(4, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(5, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(5, other.optimizedAttributeGet(IdUpdateDate));
	}
}
